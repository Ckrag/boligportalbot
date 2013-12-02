using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    class Data_Request
    {
        public List<CountryRegionAmt> regiondatalist;

        //SET DEFAULT VALUES!
        public Data_Request(){
            AmtPostnr_UI regiondata = new AmtPostnr_UI();
            regiondatalist = regiondata.regionDataList;
            
            //Console.WriteLine(testui.regionDataList[0].name);
            //Console.WriteLine(testui.regionDataList[0].postnrList[0].name);
            //Console.WriteLine(testui.regionDataList[0].postnrList[0].postnr);
        }
        
        //vars
        //makeJSONDatoObj
        //updateSearchResult

        private bool ValidateInputs()
        {
            //check validity of all inputs, before constructing object
            return true;
        }

        

    }
}
