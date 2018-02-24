using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class UserFilter
    {
        public UserFilter()
        {
            FieldSort = new HashSet<FieldSort>();
        }

        public int UserFilterId { get; set; }
        public int UserId { get; set; }
        public int? LanguageId { get; set; }
        public bool? IsWeb { get; set; }
        public bool? IsPm { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsOnSite { get; set; }
        public bool? IsPublic { get; set; }
        public bool? IsEta { get; set; }
        public bool? IsSurveyNeeded { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public User User { get; set; }
        public ICollection<FieldSort> FieldSort { get; set; }
    }
}
