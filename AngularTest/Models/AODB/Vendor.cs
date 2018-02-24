using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Vendor
    {
        public Vendor()
        {
            Attachment = new HashSet<Attachment>();
            ClientVendor = new HashSet<ClientVendor>();
            InverseParent = new HashSet<Vendor>();
            UserVendor = new HashSet<UserVendor>();
            VendorClientAttachment = new HashSet<VendorClientAttachment>();
            VendorHoliday = new HashSet<VendorHoliday>();
            VendorInternational = new HashSet<VendorInternational>();
            XmlvendorConfig = new HashSet<XmlvendorConfig>();
        }

        public int VendorId { get; set; }
        public int? CommunicationId { get; set; }
        public int? HistoryDaysId { get; set; }
        public int LanguageId { get; set; }
        public int? CompanyLanguageId { get; set; }
        public int TimeZoneId { get; set; }
        public int? ParentId { get; set; }
        public string CompanyName { get; set; }
        public string Ein { get; set; }
        public string Pin { get; set; }
        public bool? CanEditContacts { get; set; }
        public bool? CanUpdateDocuments { get; set; }
        public bool? IsTrained { get; set; }
        public string VendorCode { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int VendorTypeId { get; set; }
        public string AttachmentFolderName { get; set; }
        public int? PaymentMethodId { get; set; }
        public bool? IsVirtualVendor { get; set; }

        public Vendor Parent { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public VendorType VendorType { get; set; }
        public ICollection<Attachment> Attachment { get; set; }
        public ICollection<ClientVendor> ClientVendor { get; set; }
        public ICollection<Vendor> InverseParent { get; set; }
        public ICollection<UserVendor> UserVendor { get; set; }
        public ICollection<VendorClientAttachment> VendorClientAttachment { get; set; }
        public ICollection<VendorHoliday> VendorHoliday { get; set; }
        public ICollection<VendorInternational> VendorInternational { get; set; }
        public ICollection<XmlvendorConfig> XmlvendorConfig { get; set; }
    }
}
