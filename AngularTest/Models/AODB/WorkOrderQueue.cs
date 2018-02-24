using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueue
    {
        public WorkOrderQueue()
        {
            WorkOrderQueueTracking = new HashSet<WorkOrderQueueTracking>();
            WorkOrderQueueUser = new HashSet<WorkOrderQueueUser>();
            WorkOrderQueueWorkOrderQueueStatus = new HashSet<WorkOrderQueueWorkOrderQueueStatus>();
        }

        public int WorkOrderQueueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Filters { get; set; }
        public bool Exclude { get; set; }
        public bool TimeZoneRule { get; set; }
        public TimeSpan? HoldOnTime { get; set; }
        public string GroupByProperty { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? WorkOrderQueueHierarchyId { get; set; }
        public int WorkOrderQueueTypeId { get; set; }

        public WorkOrderQueueHierarchy WorkOrderQueueHierarchy { get; set; }
        public WorkOrderQueueType WorkOrderQueueType { get; set; }
        public ICollection<WorkOrderQueueTracking> WorkOrderQueueTracking { get; set; }
        public ICollection<WorkOrderQueueUser> WorkOrderQueueUser { get; set; }
        public ICollection<WorkOrderQueueWorkOrderQueueStatus> WorkOrderQueueWorkOrderQueueStatus { get; set; }
    }
}
