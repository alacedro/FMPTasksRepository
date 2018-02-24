using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Client
    {
        public Client()
        {
            AlertNotificationQueueAttachment = new HashSet<AlertNotificationQueueAttachment>();
            Attachment = new HashSet<Attachment>();
            ClientConfigurationAttribute = new HashSet<ClientConfigurationAttribute>();
            ClientDescription = new HashSet<ClientDescription>();
            ClientVendor = new HashSet<ClientVendor>();
            Dninumber = new HashSet<Dninumber>();
            FeatureClient = new HashSet<FeatureClient>();
            FinanceValidationParameters = new HashSet<FinanceValidationParameters>();
            HiddenWorkOrderFields = new HashSet<HiddenWorkOrderFields>();
            MarkUp = new HashSet<MarkUp>();
            Survey = new HashSet<Survey>();
            UserClient = new HashSet<UserClient>();
            VendorClientAttachment = new HashSet<VendorClientAttachment>();
            VendorInternational = new HashSet<VendorInternational>();
            WorkOrderStatusHiddenFromVendor = new HashSet<WorkOrderStatusHiddenFromVendor>();
            XmlvendorConfig = new HashSet<XmlvendorConfig>();
        }

        public int ClientId { get; set; }
        public int Dbid { get; set; }
        public int? CommunicationId { get; set; }
        public int LanguageId { get; set; }
        public int CompanyLanguageId { get; set; }
        public int TimeZoneId { get; set; }
        public int? ClientTypeId { get; set; }
        public string Idnumber { get; set; }
        public string DomainName { get; set; }
        public string CompanyName { get; set; }
        public string Abbreviation { get; set; }
        public string ReportingServerUrl { get; set; }
        public string AttachmentTempPath { get; set; }
        public string AttachmentRootPath { get; set; }
        public string ThemeName { get; set; }
        public string UrlHeaderImage { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public string ClientSiteName { get; set; }
        public string SiteUrl { get; set; }
        public int? CustomerTypeId { get; set; }
        public string MobileTitleRgb { get; set; }
        public string MobileTitleFont { get; set; }
        public string MobileHeaderRgb { get; set; }
        public string MobileHeaderFont { get; set; }
        public string MobileLogoHeaderUrl { get; set; }
        public string IdpportalUrl { get; set; }
        public int? IdentityProviderAssertionKeyId { get; set; }

        public Communication Communication { get; set; }
        public CustomerType CustomerType { get; set; }
        public Db Db { get; set; }
        public IdentityProviderAssertionKey IdentityProviderAssertionKey { get; set; }
        public ICollection<AlertNotificationQueueAttachment> AlertNotificationQueueAttachment { get; set; }
        public ICollection<Attachment> Attachment { get; set; }
        public ICollection<ClientConfigurationAttribute> ClientConfigurationAttribute { get; set; }
        public ICollection<ClientDescription> ClientDescription { get; set; }
        public ICollection<ClientVendor> ClientVendor { get; set; }
        public ICollection<Dninumber> Dninumber { get; set; }
        public ICollection<FeatureClient> FeatureClient { get; set; }
        public ICollection<FinanceValidationParameters> FinanceValidationParameters { get; set; }
        public ICollection<HiddenWorkOrderFields> HiddenWorkOrderFields { get; set; }
        public ICollection<MarkUp> MarkUp { get; set; }
        public ICollection<Survey> Survey { get; set; }
        public ICollection<UserClient> UserClient { get; set; }
        public ICollection<VendorClientAttachment> VendorClientAttachment { get; set; }
        public ICollection<VendorInternational> VendorInternational { get; set; }
        public ICollection<WorkOrderStatusHiddenFromVendor> WorkOrderStatusHiddenFromVendor { get; set; }
        public ICollection<XmlvendorConfig> XmlvendorConfig { get; set; }
    }
}
