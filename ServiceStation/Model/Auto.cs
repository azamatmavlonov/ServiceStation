using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Helper;
using ServiceStation.Base;

namespace ServiceStation.Model
{
    public class Auto : EntityBase
    {
        public int Id { get; set; }
        public StateNumber StateNumber { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public string Fuel { get; set; }
        public double Engine { get; set; }
        public int Power { get; set; }
        public string Transmission { get; set; }
        public int OwnerId { get; set; }
        public Client Owner { get; set; }
        public int MilAge { get; set; }
    }
}
