using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    public class QueryPropperties
    {

        //ALL OPTIONS WRITTEN IN ORDER OF APPEARENCE IN ORIGINAL UI
        #region Område
        //public int[] postnrArr = { };
        public List<int> postnrArr = new List<int>();

        /* Boligtype
         * 1 - "Bornholms Amt"
         * 2 - "Frederiksborg Amt"
         * 3 - "Fyns Amt"
         * 4 - "Københavns Amt"
         * 5 - "Nordjyllands Amt"
         * 6 - "Ribe Amt"
         * 7 - "Ringkøbing Amt"
         * 8 - "Roskilde Amt"
         * 9 - "Storstrøms Amt"
         * 10 - "Sønderjyllands Amts"
         * 11 - "Vejle Amt"
         * 12 - "Vestsjællands Amt"
         * 13 - "Viborg Amt"
         * 14 - "Århus Amt"
         */
        public string amtId = "";
        #endregion
        #region Boligtype
        /* Boligtype
         * 0 - "Alle boligtyper har interesse" <-- UNSELECTS ALL OTHER OPTIONS
         * 1 - "Værelse"
         * 2 - "1 Værelses"
         * 3 - "2 Værelses"
         * 4 - "3 Værelses"
         * 9 - "4 Vær. eller større"
         * 5 - "Hus/villa"
         * 8 - "Parkering"
         */
        //public string[] boligTypeArr = { "0" };
        public List<string> boligTypeArr = new List<string>();
        #endregion
        #region Størrelse og pris
        /* Husleje (min)
         * 0 - "0 kr."
         * 1000 - "1.000 kr."
         * 2000 - "2.000 kr."
         * 3000 - "3.000 kr."
         * 4000 - "4.000 kr."
         * 5000 - "5.000 kr."
         * 6000 - "6.000 kr."
         * 7000 - "7.000 kr."
         * 8000 - "8.000 kr."
         * 9000 - "9.000 kr."
         * 10000 - "10.000 kr."
         * 11000 - "11.000 kr."
         * 12000 - "12.000 kr."
         * 13000 - "13.000 kr."
         * 14000 - "14.000 kr."
         */
        public string huslejeMin = "0";
        /* Husleje (max)
         * 0 - "0 kr."
         * 1000 - "1.000 kr."
         * 2000 - "2.000 kr."
         * 3000 - "3.000 kr."
         * 4000 - "4.000 kr."
         * 5000 - "5.000 kr."
         * 6000 - "6.000 kr."
         * 7000 - "7.000 kr."
         * 8000 - "8.000 kr."
         * 9000 - "9.000 kr."
         * 10000 - "10.000 kr."
         * 11000 - "11.000 kr."
         * 12000 - "12.000 kr."
         * 13000 - "13.000 kr."
         * 14000 - "14.000 kr."
         * 15000 - "15.000+ kr"
         */
        public string huslejeMax = "4000";
        /* Størrelse (min)
         * 0 - "0 m2"
         * 10 - "10 m2"
         * 20 - "20 m2"
         * 30 - "30 m2"
         * 40 - "40 m2"
         * 50 - "50 m2"
         * 60 - "60 m2"
         * 70 - "70 m2"
         * 80 - "80 m2"
         * 90 - "90 m2"
         * 100 - "100 m2"
         * 110 - "110 m2"
         * 120 - "120 m2"
         * 130 - "130 m2"
         * 140 - "140 m2"
         * 150 - "150 m2"
         * 160 - "160 m2"
         * 170 - "170 m2"
         * 180 - "180 m2"
         * 190 - "190 m2"
         */
        public string stoerrelseMin = "0";
        /* Størrelse (max)
         * 0 - "0 m2"
         * 10 - "10 m2"
         * 20 - "20 m2"
         * 30 - "30 m2"
         * 40 - "40 m2"
         * 50 - "50 m2"
         * 60 - "60 m2"
         * 70 - "70 m2"
         * 80 - "80 m2"
         * 90 - "90 m2"
         * 100 - "100 m2"
         * 110 - "110 m2"
         * 120 - "120 m2"
         * 130 - "130 m2"
         * 140 - "140 m2"
         * 150 - "150 m2"
         * 160 - "160 m2"
         * 170 - "170 m2"
         * 180 - "180 m2"
         * 190 - "190 m2"
         * 0 - "200+ m2"
         */
        public string stoerrelseMax = "0";
        #endregion
        #region Min. lejeperiode
        /* Lejelængde
         * 1 - "2-12 mdr"
         * 2 - "1-2 år"
         * 6 - "+2 år"
         * 3 - "Ubegrænset lejeperiode" <-- UNSELECTS ALL OTHER OPTIONS
         * 4 - "Alle har interesse" <-- UNSELECTS ALL OTHER OPTIONS
         */
        //public string[] lejeLaengdeArr = { "4" };
        public List<string> lejeLaengdeArr = new List<string>();
        #endregion
        #region Andre valg
        /* "Vis kun fremleje"
         *  1 *selected*
         * -1 *unselected*
         */
        public int fremlejere = -1;

        /* "Vis kun Almene boliger"
         *  1 *selected*
         * -1 *unselected*
         */
        public int almen = -1;

        /* "Vis kun annoncer med billeder"
         *  1 *selected*
         * -1 *unselected*
         */
        public int billeder = -1;

        /* "Husdyr tilladt"
         *  1 *selected*
         * -1 *unselected*
         */
        public int husdyr = -1;

        /* "Vis kun møblerede boliger"
         *  1 *selected*
         * -1 *unselected*
         */
        public int mobleret = -1;

        /* "Vis kun delevenlige"
         *  1 *selected*
         * -1 *unselected*
         */
        public int delevenlig = -1;

        /* "Seneste overtagelsesdato"
         * format - "01/10/2013"
         * or     - "" (empty)
         */
        //On the site a button "Vis alle" clears the input field but wether that checkbox is selected or not has no effect on the json
        public string overtagdato = "";

        /* "Fritekst søgning (min 4 tegn)"
         *  "" - Doesn't search for anything
         *  "test" - Searches for matches on "test"
         */
        public string fritekst = "";

        #endregion

        #region unused propperties
        public string page = "1";   //was for some reason different "pageno"
        public string limit = "15";   //was for some reason different "pagelimit"
        public string sortCol = "3";
        public string sortDesc = "1";
        public int visOnSiteBolig = 0; //also different "onSiteBolig"        
        public string emailservice = "";
        public bool kunNyeste = false;
        public string muListeMuId = "";
        #endregion

        public QueryPropperties()
        {
            if (boligTypeArr.Count() == 0) { boligTypeArr.Add("0"); };
            if (lejeLaengdeArr.Count() == 0) { lejeLaengdeArr.Add("4"); };
        }


    }
}
