using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FilterField
    {
        public int FilterFieldId { get; set; }
        public int FieldId { get; set; }
        public int? LanguageId { get; set; }
        public int Order { get; set; }
        public string Conjunction { get; set; }
        public string Condition { get; set; }
        public string ValueHigh { get; set; }
        public string ValueLow { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Field Field { get; set; }
    }
}
