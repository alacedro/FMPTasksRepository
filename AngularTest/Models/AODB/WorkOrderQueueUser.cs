using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueUser
    {
        public int WorkOrderQueueUserId { get; set; }
        public int WorkOrderQueueId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public WorkOrderQueue WorkOrderQueue { get; set; }
    }
}
