using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading;
using Newtonsoft.Json;

namespace boligportalbot
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Request = new APIQueryHandler(system_message_txt, this, offer_groupbox);
            Query_Properties = new QueryPropperties();

            //TODO//
            //JSON TESTING
            //CHECK IF NEWER VERSION AVAILIBLE
            //STATISTICS
        }

        APIQueryHandler Request;
        public QueryPropperties Query_Properties;

        bool scanning_for_offer = false; //if currently scanning or not
        int time_between_Scans = 20000; //milisec per scan       

        #region eventlisteners
        private void start_scan_btn_Click(object sender, EventArgs e)
        {
            loading_pic.Visible = true;
            //bools
            start_scan_btn.Enabled = false;
            stop_scan_btn.Enabled = true;
            scanning_for_offer = true;
            //text
            scan_status_txt.Text = "Running..";
            CrossThreadMsg.CreateMessage(system_message_txt, "Scanner started");
            //threads
            query_worker.RunWorkerAsync(); //keeps sending requests
        }

        private void stop_scan_btn_Click(object sender, EventArgs e)
        {
            //disable the stop button, for added userfriendlyness! ..so they won't spam click while worker stops.
            stop_scan_btn.Enabled = false;
            //text
            scan_status_txt.Text = "Stopping...";
            CrossThreadMsg.CreateMessage(system_message_txt, "Scanner interrupted..");
            //threads
            query_worker.CancelAsync(); //stop sending requests
        }

        private void search_criteria_btn_Click(object sender, EventArgs e)
        {
            CriteriaForm form_C = new CriteriaForm(this);
            form_C.StartPosition = FormStartPosition.Manual;
            form_C.Location = new Point(this.Location.X + (this.Width - form_C.Width) / 2, this.Location.Y + (this.Height - form_C.Height) / 2);
            form_C.Show(this);
        }

        private void system_message_txt_TextChanged(object sender, EventArgs e)
        {
            system_message_txt.SelectionStart = system_message_txt.Text.Length;
            system_message_txt.ScrollToCaret();
        }

        private void offerBtnClick(object sender, EventArgs e)
        {
            OfferButton senderInfo = sender as OfferButton;

            //not completly sure if I need this delegate, as I assume that all forms are opened on the main UIthread, but anyway better safe than sorry
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { offerBtnClick(sender, e); });
            }
            else
            {
                //set newoffer to false, after it has been opened
                senderInfo.ParsedObject.new_offer = false;
                offer_groupbox.Invoke(new MethodInvoker(delegate { offer_groupbox.Controls.Clear(); }));
                CreateButtons();
                //open form
                OfferForm form_O = new OfferForm(senderInfo);
                form_O.StartPosition = FormStartPosition.Manual;
                form_O.Location = new Point(this.Location.X + (this.Width - form_O.Width) / 2, this.Location.Y + (this.Height - form_O.Height) / 2);
                form_O.Show(this);
            }
        }
        #endregion

        #region backgroundworker
        private void query_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (scanning_for_offer)
            {
                if (query_worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                } 
                else 
                {
                    Request.requestAPI();
                    Thread.Sleep(time_between_Scans);
                }
            }
        }

        private void query_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //reenable buttons when worker is done
            scanning_for_offer = false;
            start_scan_btn.Enabled = true;
            stop_scan_btn.Enabled = false;
            scan_status_txt.Text = "Stopped";
            CrossThreadMsg.CreateMessage(system_message_txt, "Scanner Stopped");
            loading_pic.Visible = false;
        }
        #endregion

        public void UpdateUI(JObject jdata)
        {
            //Updates the cache and creates buttons based on it.
            Request.UpdateCache(jdata);
            CreateButtons();
            CrossThreadMsg.CreateMessage(system_message_txt, "Cache updated");
        }

        private void CreateButtons()
        {
            int btn_height = 25;
            int btn_width = 300;
            int offsetX = 20;
            int offsetY = 20;
            int spacinngY = 5;

            //create buttons
            foreach(Offer offer in Request.offer_cache){
                //implements an inherited button, to add a custome attribute
                OfferButton offerBtn = new OfferButton();
                offerBtn.Click += offerBtnClick;
                offerBtn.Name = "an_offer_btn";
                offerBtn.Width = btn_width;
                offerBtn.Height = btn_height;
                offerBtn.Text = offer.headline;
                offerBtn.Top = offsetY;
                offerBtn.Left = offsetX;
                offerBtn.ParsedObject = offer;

                if (offer.new_offer)
                {
                    //if new, add label
                    Label newLabel = new Label();
                    newLabel.Text = "new";
                    newLabel.Width = 100;
                    newLabel.Height = 20;
                    newLabel.Top = offsetY;
                    newLabel.Left = offsetX + offerBtn.Width + offsetX;
                    offer_groupbox.Invoke(new MethodInvoker(delegate { offer_groupbox.Controls.Add(newLabel); }));
                }


                //add control element from worker thread
                offer_groupbox.Invoke(new MethodInvoker(delegate { offer_groupbox.Controls.Add(offerBtn); }));

                offsetY += btn_height + spacinngY;
            }           
        } 
    }
}
