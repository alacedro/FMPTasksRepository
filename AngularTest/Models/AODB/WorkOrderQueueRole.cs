using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueRole
    {
        public WorkOrderQueueRole()
        {
            WorkOrderQueueAccess = new HashSet<WorkOrderQueueAccess>();
        }

        public int WorkOrderQueueRoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public ICollection<WorkOrderQueueAccess> WorkOrderQueueAccess { get; set; }
    }
}
