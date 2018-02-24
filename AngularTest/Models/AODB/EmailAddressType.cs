using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class EmailAddressType
    {
        public EmailAddressType()
        {
            EmailAddressEmailAddressType = new HashSet<EmailAddressEmailAddressType>();
            WorkOrderQueueNotificationEmailAddressType = new HashSet<WorkOrderQueueNotificationEmailAddressType>();
        }

        public int EmailAddressTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<EmailAddressEmailAddressType> EmailAddressEmailAddressType { get; set; }
        public ICollection<WorkOrderQueueNotificationEmailAddressType> WorkOrderQueueNotificationEmailAddressType { get; set; }
    }
}
