using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueStatus
    {
        public WorkOrderQueueStatus()
        {
            WorkOrderQueueNotificationTemplateWorkOrderQueueStatus = new HashSet<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus>();
            WorkOrderQueueNotificationWorkOrderQueueStatus = new HashSet<WorkOrderQueueNotificationWorkOrderQueueStatus>();
            WorkOrderQueueWorkOrderQueueStatus = new HashSet<WorkOrderQueueWorkOrderQueueStatus>();
        }

        public int WorkOrderQueueStatusId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus> WorkOrderQueueNotificationTemplateWorkOrderQueueStatus { get; set; }
        public ICollection<WorkOrderQueueNotificationWorkOrderQueueStatus> WorkOrderQueueNotificationWorkOrderQueueStatus { get; set; }
        public ICollection<WorkOrderQueueWorkOrderQueueStatus> WorkOrderQueueWorkOrderQueueStatus { get; set; }
    }
}
