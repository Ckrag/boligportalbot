using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boligportalbot
{
    class APIQueryHandler
    {
        //system textbox reference from MainForm
        TextBox system_message_txt;
        MainForm parrentForm;
        GroupBox parrentOffer_Groupbox;

        public List<Offer> offer_cache = new List<Offer>();
        List<Offer> temp_offer_cache = new List<Offer>();

        //CONSTRUCTOR
        public APIQueryHandler(TextBox _system_message_txt, MainForm _parrent_form, GroupBox _parrent_groupbox){
            system_message_txt = _system_message_txt;
            parrentForm = _parrent_form;
            parrentOffer_Groupbox = _parrent_groupbox;
        }

        public void requestAPI()
        {
            CrossThreadMsg.CreateMessage(system_message_txt, "Request sent");
            HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create("http://www.boligportal.dk/api/soeg_leje_bolig.php");

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "serviceName=getProperties";

            //make condition to allow easy testing
            postData += "&data=" + ConstJSON();
            //postData += "&data=" + test_string;
            
            byte[] data = encoding.GetBytes(postData);
            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            httpWReq.ContentLength = data.Length;

            try
            {
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                string respondstring = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //translate the json response to offer objects
                ReadJSON(respondstring);
            }
            catch (WebException ex)
            {
                //handle Status Code 503 (Service Unavailable)
                CrossThreadMsg.CreateMessage(system_message_txt, "Error: " + ex.Message);
            }

        }

        private string ConstJSON()
        {
            string output = JsonConvert.SerializeObject(parrentForm.Query_Properties);
            return output;
        }

        private void ReadJSON(string json_string)
        {
            JObject jdata = JObject.Parse(json_string);
            //check if cache is empty (happens first time it runs)
            if (offer_cache.Count > 0)
            {
                //checks if the newest offer was changed, by comparing ID of newest cached offer with the ID if the received list
                if ((string)jdata["properties"][0]["jqt_adId"] != offer_cache[0].id)
                {
                    //system messages
                    CrossThreadMsg.CreateMessage(system_message_txt, "New offer didn't match existing, updating offers!");
                    CrossThreadMsg.CreateMessage(system_message_txt, "-> Old ID = " + offer_cache[0].id + ", New ID = " + (string)jdata["properties"][0]["jqt_adId"]);

                    //play sound
                    var player = new System.Media.SoundPlayer();
                    player.Stream = Properties.Resources.boing;
                    player.Play();

                    //send mail
                    //Notification notification = new Notification((string)jdata["properties"][0]["jqt_adUrl"], system_message_txt, parrentForm);

                    //CrossThreadMsg.CreateMessage(system_message_txt, "Sending notification mail");

                    //make a temporary backup before clearing cache, to have something to compare and detect if new offers are 'new'
                    temp_offer_cache.AddRange(offer_cache);
                    //empty list (after confirmed match found) and clear buttons before repopulating the interface
                    offer_cache.Clear();
                    parrentOffer_Groupbox.Invoke(new MethodInvoker(delegate { parrentOffer_Groupbox.Controls.Clear(); }));

                    //update cache, and populate buttons
                    parrentForm.UpdateUI(jdata);
                }
            }
            else
            {
                CrossThreadMsg.CreateMessage(system_message_txt, "Cache empty, filling up!");
                //update cache, and populate buttons
                parrentForm.UpdateUI(jdata);
            }
        }

        public void UpdateCache(JObject jdata)
        {
            //// CAP AT 15 ////
            //insted of '(int)jdata["properties"].Count()' we use 15 as a magic number, since we only are interested in the first few, and any new offers that may appear

            //FUCK DAT WE NEED TO CROSSCHECK EVERYTHING; YEEEEEEEHAW!

            //IF NOTHING WAS FOUND WITH THE QUERY: jqt_altList : true
            //OTHERWISE: jqt_altList : false

            for (int i = 0; i < (int)jdata["properties"].Count(); i++)
            {
                Offer offer = new Offer();
                //Headline
                offer.headline = (string)jdata["properties"][i]["jqt_headline"];
                //ID
                offer.id = (string)jdata["properties"][i]["jqt_adId"];
                //Description
                offer.description_text = (string)jdata["properties"][i]["jqt_adtext"];
                //Date created
                if ((string)jdata["properties"][i]["jqt_creationDateF"] == "I dag")
                {
                    offer.created_date = "Today";
                }
                else if ((string)jdata["properties"][i]["jqt_creationDateF"] == "I går")
                {
                    offer.created_date = "Yesterday";
                }
                else
                {
                    offer.created_date = (string)jdata["properties"][i]["jqt_creationDateF"];
                }
                //rent
                offer.rent = (string)jdata["properties"][i]["jqt_economy"]["rent"];
                //rooms
                offer.m2 = (string)jdata["properties"][i]["jqt_size"]["m2"];
                //Url
                offer.url = (string)jdata["properties"][i]["jqt_adUrl"];

                if (temp_offer_cache.Count > 0)
                {
                    foreach (Offer old_offer in temp_offer_cache)
                    {
                        //compare all old offers with the new offers, to detect which ones are new
                        if ((string)jdata["properties"][i]["jqt_adId"] != old_offer.id)
                        {
                            offer.new_offer = true;
                        }
                    }
                }


                //add to cache
                offer_cache.Add(offer);
            }
        }
    }
}
