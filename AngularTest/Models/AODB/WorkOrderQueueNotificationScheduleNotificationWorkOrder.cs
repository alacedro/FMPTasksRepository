using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationScheduleNotificationWorkOrder
    {
        public int WorkOrderQueueNotificationScheduleNotificationWorkOrderId { get; set; }
        public int WorkOrderQueueNotificationScheduleNotificationId { get; set; }
        public string WorkOrderNumber { get; set; }
        public int ClientId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public WorkOrderQueueNotificationScheduleNotification WorkOrderQueueNotificationScheduleNotification { get; set; }
    }
}
