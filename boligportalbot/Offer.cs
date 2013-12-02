using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    public class Offer
    {
        //using strings since I can't be sure they won't change the way they handle ID and other such formatting
        public string id;
        public string headline;
        public string description_text;
        public string url;
        public string rent;
        public string created_date;
        public string m2;
        public bool new_offer;

    }
}
