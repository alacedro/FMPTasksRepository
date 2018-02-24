using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueNotificationEmailAddressType
    {
        public int WorkOrderQueueNotificationEmailAddressTypeId { get; set; }
        public int WorkOrderQueueNotificationId { get; set; }
        public int EmailAddressTypeId { get; set; }
        public bool UseVendorEmail { get; set; }
        public bool UseClientEmail { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public EmailAddressType EmailAddressType { get; set; }
        public WorkOrderQueueNotification WorkOrderQueueNotification { get; set; }
    }
}
