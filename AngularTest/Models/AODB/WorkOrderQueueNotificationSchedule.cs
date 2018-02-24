using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationSchedule
    {
        public WorkOrderQueueNotificationSchedule()
        {
            WorkOrderQueueNotificationScheduleNotification = new HashSet<WorkOrderQueueNotificationScheduleNotification>();
        }

        public int WorkOrderQueueNotificationScheduleId { get; set; }
        public int WorkOrderQueueNotificationId { get; set; }
        public DateTime ExecutionDateTime { get; set; }
        public int Status { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public string ErrorDetails { get; set; }

        public WorkOrderQueueNotification WorkOrderQueueNotification { get; set; }
        public ICollection<WorkOrderQueueNotificationScheduleNotification> WorkOrderQueueNotificationScheduleNotification { get; set; }
    }
}
