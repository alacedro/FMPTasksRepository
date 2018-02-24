using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            Phone = new HashSet<Phone>();
        }

        public int PhoneTypeId { get; set; }
        public int LanguageId { get; set; }
        public int Order { get; set; }
        public bool? Contact { get; set; }
        public bool? Company { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Phone> Phone { get; set; }
    }
}
