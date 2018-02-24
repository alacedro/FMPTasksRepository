using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Communication
    {
        public Communication()
        {
            Address = new HashSet<Address>();
            Client = new HashSet<Client>();
            EmailAddress = new HashSet<EmailAddress>();
            Phone = new HashSet<Phone>();
        }

        public int CommunicationId { get; set; }
        public int LanguageId { get; set; }
        public string Url { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Address> Address { get; set; }
        public ICollection<Client> Client { get; set; }
        public ICollection<EmailAddress> EmailAddress { get; set; }
        public ICollection<Phone> Phone { get; set; }
    }
}
