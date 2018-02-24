using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueHierarchy
    {
        public WorkOrderQueueHierarchy()
        {
            InverseWorkOrderQueueHierarchyParent = new HashSet<WorkOrderQueueHierarchy>();
            WorkOrderQueue = new HashSet<WorkOrderQueue>();
            WorkOrderQueueNotification = new HashSet<WorkOrderQueueNotification>();
            WorkOrderQueueNotificationTemplate = new HashSet<WorkOrderQueueNotificationTemplate>();
        }

        public int WorkOrderQueueHierarchyId { get; set; }
        public string Name { get; set; }
        public int WorkOrderQueueHierarchyTypeId { get; set; }
        public int? WorkOrderQueueHierarchyParentId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public WorkOrderQueueHierarchy WorkOrderQueueHierarchyParent { get; set; }
        public WorkOrderQueueHierarchyType WorkOrderQueueHierarchyType { get; set; }
        public ICollection<WorkOrderQueueHierarchy> InverseWorkOrderQueueHierarchyParent { get; set; }
        public ICollection<WorkOrderQueue> WorkOrderQueue { get; set; }
        public ICollection<WorkOrderQueueNotification> WorkOrderQueueNotification { get; set; }
        public ICollection<WorkOrderQueueNotificationTemplate> WorkOrderQueueNotificationTemplate { get; set; }
    }
}
