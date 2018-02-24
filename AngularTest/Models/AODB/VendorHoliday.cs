using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorHoliday
    {
        public int VendorHolidayId { get; set; }
        public int LanguageId { get; set; }
        public int VendorId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Vendor Vendor { get; set; }
    }
}
