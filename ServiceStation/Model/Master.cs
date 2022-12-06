using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Model;
using ServiceStation.Abstraction;

namespace ServiceStation.Model
{
    public class Master : Person
    {
        public int WorkExperience { get; set; }
        public string Education { get; set; }
        public string Discharge { get; set; }
    }
}
