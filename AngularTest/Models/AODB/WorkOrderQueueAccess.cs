using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueAccess
    {
        public int WorkOrderQueueAccessId { get; set; }
        public int WorkOrderQueueRoleId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public User User { get; set; }
        public WorkOrderQueueRole WorkOrderQueueRole { get; set; }
    }
}
