using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderFieldSecurity
    {
        public long WorkOrderFieldSecurityId { get; set; }
        public int WorkOrderFieldId { get; set; }
        public int? SecurityRoleId { get; set; }
        public int? UserId { get; set; }
        public bool IsNew { get; set; }
        public bool? State { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public SecurityRole SecurityRole { get; set; }
        public WorkOrderFields WorkOrderField { get; set; }
    }
}
