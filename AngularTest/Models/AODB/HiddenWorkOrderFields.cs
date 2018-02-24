using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class HiddenWorkOrderFields
    {
        public int Id { get; set; }
        public int WorkOrderFieldId { get; set; }
        public int ClientId { get; set; }
        public int? ClientRoleId { get; set; }
        public int? InternalRoleId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public Client Client { get; set; }
        public WorkOrderFields WorkOrderField { get; set; }
    }
}
