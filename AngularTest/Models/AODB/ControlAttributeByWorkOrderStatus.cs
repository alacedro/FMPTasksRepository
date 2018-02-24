using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ControlAttributeByWorkOrderStatus
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public int VendorRoleId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int ControlId { get; set; }
        public int? ClientId { get; set; }
        public int WorkOrderStatusId { get; set; }

        public VendorRole VendorRole { get; set; }
    }
}
