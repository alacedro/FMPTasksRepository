using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BatchWorkOrderJob
    {
        public int BatchWorkOrderJobId { get; set; }
        public int? BatchWorkOrderPendingId { get; set; }
        public int? BatchWorkOrderJobScheduleId { get; set; }
        public int? WorkOrderTypeId { get; set; }
        public int? WorkTypeId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? LocationId { get; set; }
        public int? VendorId { get; set; }
        public int? RequestCodeId { get; set; }
        public int? RequestTypeId { get; set; }
        public int? WorkOrderStatusId { get; set; }
        public string StoreNumber { get; set; }
        public bool? IsEmergency { get; set; }
        public string HoursToRespond { get; set; }
        public string Ponumber { get; set; }
        public int? ServiceLocationId { get; set; }
        public double? Dne { get; set; }
        public string WorkOrderDescription { get; set; }
        public int? EstimatedCompletionDuration { get; set; }
        public int? BatchJobId { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledCompleteDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetCompleteDate { get; set; }
        public string ParentWorkOrderNumber { get; set; }
        public int? CauseId { get; set; }
        public int? RemedyId { get; set; }
        public string ProjectNumber { get; set; }
        public string Comment { get; set; }
        public string CommentEmail { get; set; }
        public string Attachment { get; set; }
        public string ProjectOther { get; set; }
        public string Priority { get; set; }
        public string RequestingContact { get; set; }
        public string AlternateContact { get; set; }
        public int? DepartmentId { get; set; }
        public int? EquipmentId { get; set; }
        public string EquipmentAssetTag { get; set; }
        public int? WbseId { get; set; }
        public int? CostCenterId { get; set; }
        public int? HierarchyNodeId { get; set; }
        public string WorkOrderNumber { get; set; }
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
        public BatchWorkOrderPending BatchWorkOrderPending { get; set; }
    }
}
