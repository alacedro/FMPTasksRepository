using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorClientAttachment
    {
        public int VendorClientAttachmentId { get; set; }
        public int VendorId { get; set; }
        public int ClientId { get; set; }
        public int AttachmentId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Attachment Attachment { get; set; }
        public Client Client { get; set; }
        public Vendor Vendor { get; set; }
    }
}
