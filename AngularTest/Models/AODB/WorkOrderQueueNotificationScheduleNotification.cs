using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationScheduleNotification
    {
        public WorkOrderQueueNotificationScheduleNotification()
        {
            WorkOrderQueueNotificationScheduleNotificationWorkOrder = new HashSet<WorkOrderQueueNotificationScheduleNotificationWorkOrder>();
        }

        public int WorkOrderQueueNotificationScheduleNotificationId { get; set; }
        public int WorkOrderQueueNotificationScheduleId { get; set; }
        public int AlertNotificationQueueId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public AlertNotificationQueue AlertNotificationQueue { get; set; }
        public WorkOrderQueueNotificationSchedule WorkOrderQueueNotificationSchedule { get; set; }
        public ICollection<WorkOrderQueueNotificationScheduleNotificationWorkOrder> WorkOrderQueueNotificationScheduleNotificationWorkOrder { get; set; }
    }
}
