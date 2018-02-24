using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationTrack
    {
        public int AlertNotificationTrackId { get; set; }
        public Guid TrackKeyId { get; set; }
        public int UserId { get; set; }
        public int AlertActionStatusId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }

        public AlertActionStatus AlertActionStatus { get; set; }
    }
}
