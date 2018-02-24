using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BatchWorkOrderSource
    {
        public BatchWorkOrderSource()
        {
            BatchWorkOrderPending = new HashSet<BatchWorkOrderPending>();
        }

        public int BatchWorkOrderSourceId { get; set; }
        public int BatchJobId { get; set; }
        public string Action { get; set; }
        public string WorkOrderNumber { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string Location { get; set; }
        public string WorkOrderType { get; set; }
        public string HierarchyName { get; set; }
        public string RequestType { get; set; }
        public string RequestCode { get; set; }
        public string WorkType { get; set; }
        public string Dne { get; set; }
        public string WorkOrderStatus { get; set; }
        public string Priority { get; set; }
        public string Department { get; set; }
        public string Equipment { get; set; }
        public string EquipmentAssetTag { get; set; }
        public string WorkOrderDescription { get; set; }
        public string ServiceLocation { get; set; }
        public string RequestingContact { get; set; }
        public string AlternateContact { get; set; }
        public string ProjectNumber { get; set; }
        public string WbseValue { get; set; }
        public string Ponumber { get; set; }
        public string ProjectOther { get; set; }
        public string CostCenter { get; set; }
        public string Emergency { get; set; }
        public string Comment { get; set; }
        public string CommentEmail { get; set; }
        public string ParentWorkOrderNumber { get; set; }
        public string Cause { get; set; }
        public string Remedy { get; set; }
        public string ScheduledStartDate { get; set; }
        public string ScheduledCompleteDate { get; set; }
        public string TargetStartDate { get; set; }
        public string TargetCompleteDate { get; set; }
        public string Attachment { get; set; }
        public string EstimatedCompletionDuration { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public BatchJob BatchJob { get; set; }
        public ICollection<BatchWorkOrderPending> BatchWorkOrderPending { get; set; }
    }
}
