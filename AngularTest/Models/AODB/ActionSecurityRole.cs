using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ActionSecurityRole
    {
        public int ActionSecurityRoleId { get; set; }
        public int ActionId { get; set; }
        public int SecurityRoleId { get; set; }
        public string WorkType { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Action Action { get; set; }
    }
}
