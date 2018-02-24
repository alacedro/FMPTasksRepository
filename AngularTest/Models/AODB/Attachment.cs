using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Attachment
    {
        public Attachment()
        {
            VendorClientAttachment = new HashSet<VendorClientAttachment>();
        }

        public int AttachmentId { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int? AddedByUserId { get; set; }
        public int? AddedBySecurityRoleId { get; set; }
        public int? AddedByVendorRoleId { get; set; }
        public int? AddedByClientId { get; set; }
        public int? AddedByClientRoleId { get; set; }
        public string AddComment { get; set; }
        public string DeactivateComment { get; set; }

        public Client AddedByClient { get; set; }
        public SecurityRole AddedBySecurityRole { get; set; }
        public User AddedByUser { get; set; }
        public VendorRole AddedByVendorRole { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<VendorClientAttachment> VendorClientAttachment { get; set; }
    }
}
