using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ReportFilter
    {
        public ReportFilter()
        {
            ReportFilterUsers = new HashSet<ReportFilterUsers>();
        }

        public int ReportFilterId { get; set; }
        public string Name { get; set; }
        public string FilterCriteria { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public User User { get; set; }
        public ICollection<ReportFilterUsers> ReportFilterUsers { get; set; }
    }
}
