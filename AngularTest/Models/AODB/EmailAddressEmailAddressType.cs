using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class EmailAddressEmailAddressType
    {
        public int EmailAddressEmailAddressTypeId { get; set; }
        public int EmailAddressId { get; set; }
        public int EmailAddressTypeId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public EmailAddress EmailAddress { get; set; }
        public EmailAddressType EmailAddressType { get; set; }
    }
}
