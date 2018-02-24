using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class TaxType
    {
        public TaxType()
        {
            StateTaxType = new HashSet<StateTaxType>();
        }

        public int TaxTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int? CurrencyCodeId { get; set; }

        public CurrencyCode CurrencyCode { get; set; }
        public ICollection<StateTaxType> StateTaxType { get; set; }
    }
}
