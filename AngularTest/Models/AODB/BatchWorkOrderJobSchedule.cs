using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BatchWorkOrderJobSchedule
    {
        public BatchWorkOrderJobSchedule()
        {
            BatchWorkOrderJob = new HashSet<BatchWorkOrderJob>();
            BatchWorkOrderPending = new HashSet<BatchWorkOrderPending>();
        }

        public int BatchWorkOrderJobScheduleId { get; set; }
        public int BatchJobId { get; set; }
        public DateTime RunDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public bool? HasRun { get; set; }

        public BatchJob BatchJob { get; set; }
        public ICollection<BatchWorkOrderJob> BatchWorkOrderJob { get; set; }
        public ICollection<BatchWorkOrderPending> BatchWorkOrderPending { get; set; }
    }
}
