using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class City
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Display => Name + " - " + Country;

        public City(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}
