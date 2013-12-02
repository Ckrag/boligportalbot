using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boligportalbot
{
    public partial class OfferForm : Form
    {
        string baseUrl = "http://www.boligportal.dk";
        string url;
        public OfferForm(OfferButton senderInfo) //informaton about what button called the eventlistener to open this form
        {
            InitializeComponent();

            //populate form
            title_txt.Text = senderInfo.ParsedObject.headline;
            description_txt.Text = senderInfo.ParsedObject.description_text;
            created_txt.Text = senderInfo.ParsedObject.created_date;
            rent_txt.Text = senderInfo.ParsedObject.rent;
            rooms_txt.Text = senderInfo.ParsedObject.m2;
            url = senderInfo.ParsedObject.url;
        }
        

        private void go_to_web_btn_Click(object sender, EventArgs e)
        {
            Process.Start(baseUrl + url);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
