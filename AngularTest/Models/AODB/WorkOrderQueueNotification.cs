using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotification
    {
        public WorkOrderQueueNotification()
        {
            WorkOrderQueueNotificationEmailAddressType = new HashSet<WorkOrderQueueNotificationEmailAddressType>();
            WorkOrderQueueNotificationSchedule = new HashSet<WorkOrderQueueNotificationSchedule>();
            WorkOrderQueueNotificationWorkOrderQueueDistributionList = new HashSet<WorkOrderQueueNotificationWorkOrderQueueDistributionList>();
            WorkOrderQueueNotificationWorkOrderQueueStatus = new HashSet<WorkOrderQueueNotificationWorkOrderQueueStatus>();
        }

        public int WorkOrderQueueNotificationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Recurrence { get; set; }
        public int WorkOrderQueueHierarchyId { get; set; }
        public int? WorkOrderQueueSourceObjectId { get; set; }
        public int? WorkOrderQueueSourceObjectTypeId { get; set; }
        public int WorkOrderQueueNotificationTemplateId { get; set; }
        public string EmailCc { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public WorkOrderQueueHierarchy WorkOrderQueueHierarchy { get; set; }
        public WorkOrderQueueNotificationTemplate WorkOrderQueueNotificationTemplate { get; set; }
        public WorkOrderQueueSourceObjectType WorkOrderQueueSourceObjectType { get; set; }
        public ICollection<WorkOrderQueueNotificationEmailAddressType> WorkOrderQueueNotificationEmailAddressType { get; set; }
        public ICollection<WorkOrderQueueNotificationSchedule> WorkOrderQueueNotificationSchedule { get; set; }
        public ICollection<WorkOrderQueueNotificationWorkOrderQueueDistributionList> WorkOrderQueueNotificationWorkOrderQueueDistributionList { get; set; }
        public ICollection<WorkOrderQueueNotificationWorkOrderQueueStatus> WorkOrderQueueNotificationWorkOrderQueueStatus { get; set; }
    }
}
