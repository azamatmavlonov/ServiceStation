using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Model;
using ServiceStation.Helper;
using ServiceStation.Base;

namespace ServiceStation.Abstraction
{
    public abstract class Person : EntityBase
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportSeries { get; set; }
        public int TaxpayerIdentificationNumber { get; set; }
    }
}
