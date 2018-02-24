using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Contact
    {
        public Contact()
        {
            Address = new HashSet<Address>();
            EmailAddress = new HashSet<EmailAddress>();
            Phone = new HashSet<Phone>();
            User = new HashSet<User>();
        }

        public int ContactId { get; set; }
        public int TimeZoneId { get; set; }
        public int? PreferredContactMethodId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Title { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public PreferredContactMethod PreferredContactMethod { get; set; }
        public TimeZone TimeZone { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<EmailAddress> EmailAddress { get; set; }
        public ICollection<Phone> Phone { get; set; }
        public ICollection<User> User { get; set; }
    }
}
