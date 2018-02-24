using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class StateTaxType
    {
        public int StateTaxTypeId { get; set; }
        public int StateId { get; set; }
        public int TaxTypeId { get; set; }
        public int LanguageId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public State State { get; set; }
        public TaxType TaxType { get; set; }
    }
}
