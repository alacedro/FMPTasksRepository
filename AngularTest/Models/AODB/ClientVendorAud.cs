using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ClientVendorAud
    {
        public long ClientVendorAudid { get; set; }
        public int? ClientVendorId { get; set; }
        public int? ClientId { get; set; }
        public int? VendorId { get; set; }
        public int? LanguageId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public string PaymentTerms { get; set; }
        public string VendorCode { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Modified { get; set; }
        public string Modifier { get; set; }
    }
}
