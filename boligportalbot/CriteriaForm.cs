using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boligportalbot
{
    public partial class CriteriaForm : Form
    {

        private List<CountryRegionAmt> regiondatalist;
        MainForm parrentForm;

        public CriteriaForm(MainForm _parrentForm)
        {
            Contract.Requires(_parrentForm.GetType() == typeof(MainForm));
            
            InitializeComponent();
            Data_Request user_criteria = new Data_Request();

            Contract.Requires(user_criteria.regiondatalist.GetType() == typeof(List<CountryRegionAmt>));

            regiondatalist = user_criteria.regiondatalist;
            amt_selection_cmb.DataSource = regiondatalist;
            amt_selection_cmb.DisplayMember = "name";

            parrentForm = _parrentForm;

            //set displayed settings equal to currently selected settings
            UpdateDisplayedSettings();

        }

        public void UpdateDisplayedSettings()
        {
            //set amtID and matching post-codes
            if (parrentForm.Query_Properties.amtId != "")
            {
                amt_selection_cmb.SelectedIndex = Int32.Parse(parrentForm.Query_Properties.amtId);

                foreach (CheckBox cb in postnr_panel.Controls)
                {
                    if (cb.GetType() == typeof(CheckBox))
                    {
                        if (parrentForm.Query_Properties.postnrArr.Contains(Int32.Parse(Regex.Match(cb.Text, @"[0-9]{4}").Value)))
                        {
                            cb.Checked = true;
                        }
                        //parrentForm.Query_Properties.postnrArr.Add(Int32.Parse(Regex.Match(cb.Text, @"[0-9]{4}").Value));     
                    }

                }
            }

            //set apartment settings
            if (parrentForm.Query_Properties.boligTypeArr.Contains("0")) { all_types_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("1")) { all_aprt_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("2")) { one_room_aprt_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("3")) { two_room_aprt_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("4")) { three_room_aprt_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("9")) { four_room_aprt_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("5")) { house_villa_cb.Checked = true; };
            if (parrentForm.Query_Properties.boligTypeArr.Contains("8")) { parking_cb.Checked = true; };

            //pricing (min)
            min_price_txt.Text = parrentForm.Query_Properties.huslejeMin;
           
            //pricing (min)
            max_price_txt.Text = parrentForm.Query_Properties.huslejeMax;
            
            //size (min)
            min_size_txt.Text = parrentForm.Query_Properties.stoerrelseMin;

            //size (min)
            max_size_txt.Text = parrentForm.Query_Properties.stoerrelseMax;


            //RENT PERIOD
            if (parrentForm.Query_Properties.lejeLaengdeArr.Contains("1")) { period_months_cb.Checked = true; };
            if (parrentForm.Query_Properties.lejeLaengdeArr.Contains("2")) { rent_period_years_cb.Checked = true; };
            if (parrentForm.Query_Properties.lejeLaengdeArr.Contains("6")) { rent_period_moreyears_cb.Checked = true; };
            if (parrentForm.Query_Properties.lejeLaengdeArr.Contains("3")) { rent_period_unlimited_cb.Checked = true; };
            if (parrentForm.Query_Properties.lejeLaengdeArr.Contains("4")) { rent_period_all_cb.Checked = true; };

            //Other settings
            if (parrentForm.Query_Properties.fremlejere == 1) { only_sublets_cb.Checked = true; };
            if (parrentForm.Query_Properties.almen == 1) { only_public.Checked = true; };
            if (parrentForm.Query_Properties.billeder == 1) { only_img_cb.Checked = true; };
            if (parrentForm.Query_Properties.husdyr == 1) { pets_cb.Checked = true; };
            if (parrentForm.Query_Properties.mobleret == 1) { only_furnished_cb.Checked = true; };
            if (parrentForm.Query_Properties.delevenlig == 1) { only_sharefriendly_cb.Checked = true; };
        }

        public void SaveSelectedSettings()
        {
            //save amtID
            parrentForm.Query_Properties.amtId = amt_selection_cmb.SelectedIndex.ToString();

            
            //save Postnr
            parrentForm.Query_Properties.postnrArr.Clear(); //clear old list, before adding new
            foreach (CheckBox cb in postnr_panel.Controls)
            {
                if (cb.GetType() == typeof(CheckBox))
                {
                    if (cb.Checked)
                    {
                        parrentForm.Query_Properties.postnrArr.Add(Int32.Parse(Regex.Match(cb.Text, @"[0-9]{4}").Value));
                    }
                }
            }

            //apartmenttype settings
            parrentForm.Query_Properties.boligTypeArr.Clear(); //clear old list, before adding new
            if (all_types_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("0"); };
            if (all_aprt_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("1"); };
            if (one_room_aprt_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("2"); };
            if (two_room_aprt_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("3"); };
            if (three_room_aprt_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("4"); };
            if (four_room_aprt_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("9"); };
            if (house_villa_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("5"); };
            if (parking_cb.Checked) { parrentForm.Query_Properties.boligTypeArr.Add("8"); };

            #region price/size
            //pricing (min)

            if (min_price_txt.Text == "") { parrentForm.Query_Properties.huslejeMin = "0"; }
            else {
                if (Regex.IsMatch(min_price_txt.Text, @"[0-9]{1,6}"))
                {
                    parrentForm.Query_Properties.huslejeMin = min_price_txt.Text;
                }
                else
                {
                    parrentForm.Query_Properties.huslejeMin = "0";
                }
            };
            //pricing (max)
            if (max_price_txt.Text == "") { parrentForm.Query_Properties.huslejeMax = "0"; }
            else
            {
                if (Regex.IsMatch(min_price_txt.Text, @"[0-9]{1,6}"))
                {
                    parrentForm.Query_Properties.huslejeMax = max_price_txt.Text;
                }
                else
                {
                    parrentForm.Query_Properties.huslejeMax = "0";
                }
            };
            //size (min)
            if (min_size_txt.Text == "") { parrentForm.Query_Properties.stoerrelseMin = "0"; }
            else
            {
                if (Regex.IsMatch(min_price_txt.Text, @"[0-9]{1,4}"))
                {
                    parrentForm.Query_Properties.stoerrelseMin = max_size_txt.Text;
                }
                else
                {
                    parrentForm.Query_Properties.stoerrelseMin = "0";
                }
            };
            //size (max)
            if (max_size_txt.Text == "") { parrentForm.Query_Properties.stoerrelseMax = "0"; }
            else
            {
                if (Regex.IsMatch(min_price_txt.Text, @"[0-9]{1,4}"))
                {
                    parrentForm.Query_Properties.stoerrelseMax = max_size_txt.Text;
                }
                else
                {
                    parrentForm.Query_Properties.stoerrelseMax = "0";
                }
            };

            #endregion

            //RENT PERIOD
            parrentForm.Query_Properties.lejeLaengdeArr.Clear(); //clear old list, before adding new
            foreach (CheckBox cb in rent_priod_gb.Controls)
            {
                if (cb.GetType() == typeof(CheckBox))
                {
                    if (cb.Checked)
                    {
                        if (cb.Name == "period_months_cb") { parrentForm.Query_Properties.lejeLaengdeArr.Add("1"); }
                        if (cb.Name == "rent_period_years_cb") { parrentForm.Query_Properties.lejeLaengdeArr.Add("2"); }
                        if (cb.Name == "rent_period_moreyears_cb") { parrentForm.Query_Properties.lejeLaengdeArr.Add("6"); }
                        if (cb.Name == "rent_period_unlimited_cb") { parrentForm.Query_Properties.lejeLaengdeArr.Add("3"); }
                        if (cb.Name == "rent_period_all_cb") { parrentForm.Query_Properties.lejeLaengdeArr.Add("4"); }
                    }
                }
            }

            //Other settings
            if (only_sublets_cb.Checked) { parrentForm.Query_Properties.fremlejere = 1; }
            else { parrentForm.Query_Properties.fremlejere = -1; };
            if (only_public.Checked) { parrentForm.Query_Properties.almen = 1; }
            else { parrentForm.Query_Properties.almen = -1; };
            if (only_img_cb.Checked) { parrentForm.Query_Properties.billeder = 1; }
            else { parrentForm.Query_Properties.billeder = -1; };
            if (pets_cb.Checked) { parrentForm.Query_Properties.husdyr = 1; }
            else { parrentForm.Query_Properties.husdyr = -1; };
            if (only_furnished_cb.Checked) { parrentForm.Query_Properties.mobleret = 1; }
            else { parrentForm.Query_Properties.mobleret = -1; };
            if (only_sharefriendly_cb.Checked) { parrentForm.Query_Properties.delevenlig = 1; }
            else { parrentForm.Query_Properties.delevenlig = -1; };

            

        }

        public void GeneratePostCB()
        {
            postnr_panel.Controls.Clear();

            int regionListLenght = regiondatalist[amt_selection_cmb.SelectedIndex].postnrList.Count();
            int colsCreated = 1;
            int numberOfCols = 2;
            int col_height = (regionListLenght - (regionListLenght % numberOfCols)) / numberOfCols; //calculates the minimum length of each row needed to fill it with the entire list            

            int cb_height = 25;
            int cb_width = 150;
            int offsetX = 0;
            int offsetY = 0;
            int spacingY = 5;


            for (int i = 0; i < regiondatalist[amt_selection_cmb.SelectedIndex].postnrList.Count() - 1; i++) //-1 since lists are 0-based
            {
                /*
                if (i <= col_height*colsCreated)
                {
                    offsetX = (colsCreated * cb_width) - cb_width;
                }
                else
                {
                    colsCreated++;
                    offsetY = 0;
                }
                 */

                //Console.WriteLine(regiondatalist[amt_selection_cmb.SelectedIndex].postnrList[0].postnr);
                CheckBox postnr_cb = new CheckBox();
                postnr_cb.Text = regiondatalist[amt_selection_cmb.SelectedIndex].postnrList[i].postnr + " " + regiondatalist[amt_selection_cmb.SelectedIndex].postnrList[i].name;
                postnr_cb.Top = offsetY;
                postnr_cb.Left = offsetX;
                postnr_cb.Width = cb_width;

                postnr_panel.Controls.Add(postnr_cb);

                offsetY += cb_height + spacingY;

                //Console.WriteLine(numberOfCols);
                //Console.WriteLine("x: " + offsetX + " y: " + offsetY);
                //Console.WriteLine("Btn nr " + i);
                //Console.WriteLine("-------------");

            }



            //Console.WriteLine(testui.regionDataList[0].name);
            //Console.WriteLine(testui.regionDataList[0].postnrList[0].name);
            //Console.WriteLine(testui.regionDataList[0].postnrList[0].postnr);
        }

        #region events

        private void amt_selection_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeneratePostCB();
        }

        private void accept_settings_btn_Click(object sender, EventArgs e)
        {
            SaveSelectedSettings();
            this.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
