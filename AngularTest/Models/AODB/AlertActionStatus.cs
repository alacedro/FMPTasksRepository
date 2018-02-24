using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertActionStatus
    {
        public AlertActionStatus()
        {
            AlertNotificationQueue = new HashSet<AlertNotificationQueue>();
            AlertNotificationTrack = new HashSet<AlertNotificationTrack>();
        }

        public int AlertActionStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreatedUser { get; set; }

        public ICollection<AlertNotificationQueue> AlertNotificationQueue { get; set; }
        public ICollection<AlertNotificationTrack> AlertNotificationTrack { get; set; }
    }
}
