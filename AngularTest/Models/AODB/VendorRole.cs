using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorRole
    {
        public VendorRole()
        {
            Attachment = new HashSet<Attachment>();
            ControlAttributeByWorkOrderStatus = new HashSet<ControlAttributeByWorkOrderStatus>();
            User = new HashSet<User>();
        }

        public int VendorRoleId { get; set; }
        public int? LanguageId { get; set; }
        public int? Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Attachment> Attachment { get; set; }
        public ICollection<ControlAttributeByWorkOrderStatus> ControlAttributeByWorkOrderStatus { get; set; }
        public ICollection<User> User { get; set; }
    }
}
