using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            VendorInternational = new HashSet<VendorInternational>();
        }

        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int CurrencyCodeId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public CurrencyCode CurrencyCode { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<VendorInternational> VendorInternational { get; set; }
    }
}
