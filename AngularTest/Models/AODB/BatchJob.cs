using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BatchJob
    {
        public BatchJob()
        {
            BatchWorkOrderJobSchedule = new HashSet<BatchWorkOrderJobSchedule>();
            BatchWorkOrderSource = new HashSet<BatchWorkOrderSource>();
        }

        public int BatchJobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public bool IsOneTimeRun { get; set; }
        public int? BatchJobStatusId { get; set; }
        public int? DataActionId { get; set; }
        public int? DataEntityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public int? LeadTimeIntervalTypeId { get; set; }
        public int? LeadTimeIntervalValue { get; set; }
        public int? ScheduleTimeIntervalTypeId { get; set; }
        public int? ScheduleTimeIntervalValue { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<BatchWorkOrderJobSchedule> BatchWorkOrderJobSchedule { get; set; }
        public ICollection<BatchWorkOrderSource> BatchWorkOrderSource { get; set; }
    }
}
