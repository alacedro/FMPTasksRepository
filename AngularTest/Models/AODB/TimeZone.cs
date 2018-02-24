using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            Contact = new HashSet<Contact>();
        }

        public int TimeZoneId { get; set; }
        public int LanguageId { get; set; }
        public int Order { get; set; }
        public string Code { get; set; }
        public decimal Offset { get; set; }
        public decimal? DaylightSavingOffset { get; set; }
        public DateTime? DaylightSavingStartDate { get; set; }
        public DateTime? DaylightSavingEndDate { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Contact> Contact { get; set; }
    }
}
