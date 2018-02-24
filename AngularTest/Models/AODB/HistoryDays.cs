using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class HistoryDays
    {
        public int HistoryDaysId { get; set; }
        public int LanguageId { get; set; }
        public int? WorkOrder { get; set; }
        public int? Vendor { get; set; }
        public int? Property { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
