using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FieldSort
    {
        public int FieldSortId { get; set; }
        public int UserFilterId { get; set; }
        public int FieldId { get; set; }
        public int? LanguageId { get; set; }
        public bool Direction { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Field Field { get; set; }
        public UserFilter UserFilter { get; set; }
    }
}
