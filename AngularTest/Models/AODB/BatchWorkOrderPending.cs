using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BatchWorkOrderPending
    {
        public BatchWorkOrderPending()
        {
            BatchWorkOrderJob = new HashSet<BatchWorkOrderJob>();
        }

        public int BatchWorkOrderPendingId { get; set; }
        public int? BatchWorkOrderSourceId { get; set; }
        public int BatchJobId { get; set; }
        public int? BatchWorkOrderJobScheduleId { get; set; }
        public string Action { get; set; }
        public string WorkOrderNumber { get; set; }
        public string VendorCode { get; set; }
        public int? VendorCodeId { get; set; }
        public string VendorName { get; set; }
        public string Location { get; set; }
        public int? LocationId { get; set; }
        public string WorkOrderType { get; set; }
        public int? WorkOrderTypeId { get; set; }
        public string HierarchyName { get; set; }
        public int? HierarchyId { get; set; }
        public string RequestType { get; set; }
        public int? RequestTypeId { get; set; }
        public string RequestCode { get; set; }
        public int? RequestCodeId { get; set; }
        public string WorkType { get; set; }
        public int? WorkTypeId { get; set; }
        public string Dne { get; set; }
        public string WorkOrderStatus { get; set; }
        public int? WorkOrderStatusId { get; set; }
        public string Priority { get; set; }
        public string PriorityId { get; set; }
        public string Department { get; set; }
        public int? DepartmentId { get; set; }
        public string Equipment { get; set; }
        public int? EquipmentId { get; set; }
        public string EquipmentAssetTag { get; set; }
        public string WorkOrderDescription { get; set; }
        public string ServiceLocation { get; set; }
        public int? ServiceLocationId { get; set; }
        public string RequestingContact { get; set; }
        public string AlternateContact { get; set; }
        public string ProjectNumber { get; set; }
        public string WbseValue { get; set; }
        public string Ponumber { get; set; }
        public string ProjectOther { get; set; }
        public string CostCenter { get; set; }
        public int? CostCenterId { get; set; }
        public string Emergency { get; set; }
        public string Comment { get; set; }
        public string CommentEmail { get; set; }
        public string ParentWorkOrderNumber { get; set; }
        public string Cause { get; set; }
        public int? CauseId { get; set; }
        public string Remedy { get; set; }
        public int? RemedyId { get; set; }
        public string ScheduledStartDate { get; set; }
        public string ScheduledCompleteDate { get; set; }
        public string TargetStartDate { get; set; }
        public string TargetCompleteDate { get; set; }
        public string Attachment { get; set; }
        public string EstimatedCompletionDuration { get; set; }
        public string ValidationSummary { get; set; }
        public bool? IsApproved { get; set; }
        public int? LeadTimeIntervalTypeId { get; set; }
        public int? LeadTimeIntervalValue { get; set; }
        public int? ScheduleTimeIntervalTypeId { get; set; }
        public int? ScheduleTimeIntervalValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public BatchWorkOrderJobSchedule BatchWorkOrderJobSchedule { get; set; }
        public BatchWorkOrderSource BatchWorkOrderSource { get; set; }
        public ICollection<BatchWorkOrderJob> BatchWorkOrderJob { get; set; }
    }
}
