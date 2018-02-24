using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationTemplateWorkOrderQueueStatus
    {
        public int WorkOrderQueueNotificationTemplateWorkOrderQueueStatusId { get; set; }
        public string Comment { get; set; }
        public int WorkOrderQueueNotificationTemplateId { get; set; }
        public int WorkOrderQueueStatusId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public WorkOrderQueueNotificationTemplate WorkOrderQueueNotificationTemplate { get; set; }
        public WorkOrderQueueStatus WorkOrderQueueStatus { get; set; }
    }
}
