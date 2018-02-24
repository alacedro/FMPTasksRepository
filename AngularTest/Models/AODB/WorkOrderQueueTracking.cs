using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueTracking
    {
        public int WorkOrderQueueTrackingId { get; set; }
        public int WorkOrderQueueId { get; set; }
        public int? UserId { get; set; }
        public string WorkOrderId { get; set; }
        public DateTime AssignedDateTime { get; set; }
        public DateTime? ExpirationDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public User User { get; set; }
        public WorkOrderQueue WorkOrderQueue { get; set; }
    }
}
