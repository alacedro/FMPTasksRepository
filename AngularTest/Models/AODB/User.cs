using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class User
    {
        public User()
        {
            Attachment = new HashSet<Attachment>();
            InternalUserFilter = new HashSet<InternalUserFilter>();
            PasswordHistory = new HashSet<PasswordHistory>();
            ReportFilter = new HashSet<ReportFilter>();
            ReportFilterUsers = new HashSet<ReportFilterUsers>();
            UserClient = new HashSet<UserClient>();
            UserConfigurationAttribute = new HashSet<UserConfigurationAttribute>();
            UserFilter = new HashSet<UserFilter>();
            UserLanguage = new HashSet<UserLanguage>();
            UserVendor = new HashSet<UserVendor>();
            WorkOrderQueueAccess = new HashSet<WorkOrderQueueAccess>();
            WorkOrderQueueTracking = new HashSet<WorkOrderQueueTracking>();
            WorkOrderQueueUser = new HashSet<WorkOrderQueueUser>();
        }

        public int UserId { get; set; }
        public int? ManagerUserId { get; set; }
        public int? SecurityRoleId { get; set; }
        public int? VendorRoleId { get; set; }
        public int? DefaultUserFilterId { get; set; }
        public int ContactId { get; set; }
        public int LanguageId { get; set; }
        public int LoginTypeId { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ExternalPassword { get; set; }
        public DateTime? LastLogin { get; set; }
        public string UserBrowser { get; set; }
        public bool? IsInDaylightSavingsArea { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public short? SyncStatus { get; set; }
        public DateTime? SyncDateTime { get; set; }
        public DateTime? PwdLastResetDate { get; set; }
        public int? DefaultPageSize { get; set; }

        public Contact Contact { get; set; }
        public LoginType LoginType { get; set; }
        public SecurityRole SecurityRole { get; set; }
        public VendorRole VendorRole { get; set; }
        public ICollection<Attachment> Attachment { get; set; }
        public ICollection<InternalUserFilter> InternalUserFilter { get; set; }
        public ICollection<PasswordHistory> PasswordHistory { get; set; }
        public ICollection<ReportFilter> ReportFilter { get; set; }
        public ICollection<ReportFilterUsers> ReportFilterUsers { get; set; }
        public ICollection<UserClient> UserClient { get; set; }
        public ICollection<UserConfigurationAttribute> UserConfigurationAttribute { get; set; }
        public ICollection<UserFilter> UserFilter { get; set; }
        public ICollection<UserLanguage> UserLanguage { get; set; }
        public ICollection<UserVendor> UserVendor { get; set; }
        public ICollection<WorkOrderQueueAccess> WorkOrderQueueAccess { get; set; }
        public ICollection<WorkOrderQueueTracking> WorkOrderQueueTracking { get; set; }
        public ICollection<WorkOrderQueueUser> WorkOrderQueueUser { get; set; }
    }
}
