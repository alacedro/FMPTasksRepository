using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Field
    {
        public Field()
        {
            FieldSort = new HashSet<FieldSort>();
            FilterField = new HashSet<FilterField>();
        }

        public int FieldId { get; set; }
        public int? LanguageId { get; set; }
        public string Page { get; set; }
        public string DisplayName { get; set; }
        public string FieldType { get; set; }
        public string FieldUi { get; set; }
        public string DatabaseName { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<FieldSort> FieldSort { get; set; }
        public ICollection<FilterField> FilterField { get; set; }
    }
}
