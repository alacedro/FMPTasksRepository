using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Phone
    {
        public int PhoneId { get; set; }
        public int? CommunicationId { get; set; }
        public int? ContactId { get; set; }
        public int LanguageId { get; set; }
        public int PhoneTypeId { get; set; }
        public bool IsPrimary { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string ExchangeAndNumber { get; set; }
        public string Extension { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public string CityCode { get; set; }

        public Communication Communication { get; set; }
        public Contact Contact { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
