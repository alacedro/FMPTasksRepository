using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ReportFilterUsers
    {
        public int ReportFilterUserId { get; set; }
        public int ReportFilterId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public ReportFilter ReportFilter { get; set; }
        public User User { get; set; }
    }
}
