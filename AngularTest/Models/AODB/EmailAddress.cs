using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class EmailAddress
    {
        public EmailAddress()
        {
            EmailAddressEmailAddressType = new HashSet<EmailAddressEmailAddressType>();
        }

        public int EmailAddressId { get; set; }
        public int? CommunicationId { get; set; }
        public int? ContactId { get; set; }
        public int LanguageId { get; set; }
        public bool IsPrimary { get; set; }
        public string Email { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Communication Communication { get; set; }
        public Contact Contact { get; set; }
        public ICollection<EmailAddressEmailAddressType> EmailAddressEmailAddressType { get; set; }
    }
}
