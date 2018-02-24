using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationTemplate
    {
        public WorkOrderQueueNotificationTemplate()
        {
            WorkOrderQueueNotification = new HashSet<WorkOrderQueueNotification>();
            WorkOrderQueueNotificationTemplateWorkOrderQueueStatus = new HashSet<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus>();
        }

        public int WorkOrderQueueNotificationTemplateId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int WorkOrderQueueHierarchyId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int WorkOrderQueueNotificationTemplateTypeId { get; set; }
        public int MaxRecordsToReturn { get; set; }

        public WorkOrderQueueHierarchy WorkOrderQueueHierarchy { get; set; }
        public WorkOrderQueueNotificationTemplateType WorkOrderQueueNotificationTemplateType { get; set; }
        public ICollection<WorkOrderQueueNotification> WorkOrderQueueNotification { get; set; }
        public ICollection<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus> WorkOrderQueueNotificationTemplateWorkOrderQueueStatus { get; set; }
    }
}
