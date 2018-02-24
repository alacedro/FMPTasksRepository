using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationQueue
    {
        public AlertNotificationQueue()
        {
            AlertNotificationQueueAttachment = new HashSet<AlertNotificationQueueAttachment>();
            WorkOrderQueueNotificationScheduleNotification = new HashSet<WorkOrderQueueNotificationScheduleNotification>();
        }

        public int AlertNotificationQueueId { get; set; }
        public int AlertNotificationTrackId { get; set; }
        public int ClientId { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }
        public int Progress { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedUser { get; set; }
        public string Bcc { get; set; }
        public bool IsHighImportance { get; set; }
        public string Cc { get; set; }
        public string ReplyTo { get; set; }
        public string Headers { get; set; }

        public AlertActionStatus ProgressNavigation { get; set; }
        public ICollection<AlertNotificationQueueAttachment> AlertNotificationQueueAttachment { get; set; }
        public ICollection<WorkOrderQueueNotificationScheduleNotification> WorkOrderQueueNotificationScheduleNotification { get; set; }
    }
}
