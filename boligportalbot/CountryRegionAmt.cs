using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    class CountryRegionAmt
    {
        public List<CountryRegionPostnr> postnrList = new List<CountryRegionPostnr>();
        public string name { get; private set; }

        public CountryRegionAmt(string _name, List<CountryRegionPostnr> _postnrList)
        {
            name = _name;
            postnrList = _postnrList;
        }
    }
}
