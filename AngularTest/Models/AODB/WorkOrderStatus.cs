using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderStatus
    {
        public WorkOrderStatus()
        {
            VendorStatusGroupMapping = new HashSet<VendorStatusGroupMapping>();
            WorkOrderStatusHiddenFromVendor = new HashSet<WorkOrderStatusHiddenFromVendor>();
            WorkOrderStatusRecall = new HashSet<WorkOrderStatusRecall>();
        }

        public int WorkOrderStatusId { get; set; }
        public int? LanguageId { get; set; }
        public int Order { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayColorImageUrl { get; set; }
        public string DisplayColor { get; set; }
        public int WorkOrderStatusGroupId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public bool? IsVendorChangeAllowed { get; set; }

        public WorkOrderStatusGroup WorkOrderStatusGroup { get; set; }
        public AutoApprovalServiceStatus AutoApprovalServiceStatus { get; set; }
        public ICollection<VendorStatusGroupMapping> VendorStatusGroupMapping { get; set; }
        public ICollection<WorkOrderStatusHiddenFromVendor> WorkOrderStatusHiddenFromVendor { get; set; }
        public ICollection<WorkOrderStatusRecall> WorkOrderStatusRecall { get; set; }
    }
}
