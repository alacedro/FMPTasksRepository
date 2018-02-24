using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FieldTag
    {
        public int FieldTagId { get; set; }
        public int? LanguageId { get; set; }
        public string Tag { get; set; }
        public string DatabaseField { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
