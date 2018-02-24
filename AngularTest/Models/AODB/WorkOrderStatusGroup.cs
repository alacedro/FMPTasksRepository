using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderStatusGroup
    {
        public WorkOrderStatusGroup()
        {
            WorkOrderStatus = new HashSet<WorkOrderStatus>();
        }

        public int WorkOrderStatusGroupId { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<WorkOrderStatus> WorkOrderStatus { get; set; }
    }
}
