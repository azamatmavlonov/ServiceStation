using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStation.Helper
{
    public class StateNumber
    {
        public string Number { get; set; }
        public string Series { get; set; }
        public string Region { get; set; }

        public override string ToString()
        {
            return $"{Number} {Series} {Region}";
        }
    }
}
