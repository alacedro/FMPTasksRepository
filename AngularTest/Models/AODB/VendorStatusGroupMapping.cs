using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorStatusGroupMapping
    {
        public int VendorStatusGroupMappingId { get; set; }
        public int VendorStatusGroupId { get; set; }
        public int WorkOrderStatusId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public VendorStatusGroup VendorStatusGroup { get; set; }
        public WorkOrderStatus WorkOrderStatus { get; set; }
    }
}
