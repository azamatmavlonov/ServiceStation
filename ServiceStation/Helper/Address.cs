using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStation.Helper
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int PostCode { get; set; }

        public override string ToString()
        {
            return $"{Country}, {City}, {Locality}, {Street}, {HouseNumber}, {PostCode}";
        }
    }
}
