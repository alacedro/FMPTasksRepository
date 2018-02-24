using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorInternational
    {
        public int VendorInternationalId { get; set; }
        public int VendorId { get; set; }
        public int ClientId { get; set; }
        public int CountryId { get; set; }
        public string AccountNumber { get; set; }
        public string SequenceNumber { get; set; }
        public string TaxNumber { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? CurrencyCodeId { get; set; }

        public Client Client { get; set; }
        public Country Country { get; set; }
        public Vendor Vendor { get; set; }
    }
}
