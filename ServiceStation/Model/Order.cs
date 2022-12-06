using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;

namespace ServiceStation.Model
{
    class Order : EntityBase
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
        public List<Service> Service { get; set; }
        public List<Master> Master { get; set; }
        public double TotalPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string SpecialMarks { get; set; }
    }
}
