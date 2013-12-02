using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    class CountryRegionPostnr
    {
        public string name { get; private set; }
        public string postnr { get; private set; } //will never need to handle them mathematically, and strings just make it easier to handle :o)

        public CountryRegionPostnr(string _name, string _postnr)
        {
            name = _name;
            postnr = _postnr;
        }
    }
}
