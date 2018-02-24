using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int? CommunicationId { get; set; }
        public int? ContactId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public int AddressTypeId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string ZipPostalCode { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public AddressType AddressType { get; set; }
        public Communication Communication { get; set; }
        public Contact Contact { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
    }
}
