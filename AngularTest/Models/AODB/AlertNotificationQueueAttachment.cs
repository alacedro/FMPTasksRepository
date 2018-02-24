using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationQueueAttachment
    {
        public int AlertNotificationQueueAttachmentId { get; set; }
        public int AlertNotificationQueueId { get; set; }
        public int ClientId { get; set; }
        public int AttachmentId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedUser { get; set; }

        public AlertNotificationQueue AlertNotificationQueue { get; set; }
        public Client Client { get; set; }
    }
}
