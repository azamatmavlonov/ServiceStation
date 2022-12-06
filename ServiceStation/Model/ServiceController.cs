using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Abstraction;

namespace ServiceStation.Model
{
    public class ServiceController : Person
    {
        public int WorkExperience { get; set; }
        public string Education { get; set; }
        public string Discharge { get; set; }
    }
}
