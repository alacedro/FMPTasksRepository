using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularTest.Models.AODB
{
    public partial class AODBContext : DbContext
    {
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<ActionSecurityRole> ActionSecurityRole { get; set; }
        public virtual DbSet<ActionUser> ActionUser { get; set; }
        public virtual DbSet<ActionVendor> ActionVendor { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AlertActionStatus> AlertActionStatus { get; set; }
        public virtual DbSet<AlertNotificationQueue> AlertNotificationQueue { get; set; }
        public virtual DbSet<AlertNotificationQueueAttachment> AlertNotificationQueueAttachment { get; set; }
        public virtual DbSet<AlertNotificationRules> AlertNotificationRules { get; set; }
        public virtual DbSet<AlertNotificationTemplate> AlertNotificationTemplate { get; set; }
        public virtual DbSet<AlertNotificationTemplatesByRulesConfig> AlertNotificationTemplatesByRulesConfig { get; set; }
        public virtual DbSet<AlertNotificationTrack> AlertNotificationTrack { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<ApiAccessLevel> ApiAccessLevel { get; set; }
        public virtual DbSet<ApiAuthorization> ApiAuthorization { get; set; }
        public virtual DbSet<ApiUsage> ApiUsage { get; set; }
        public virtual DbSet<ApplicationError> ApplicationError { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<ApplicationVersionSupport> ApplicationVersionSupport { get; set; }
        public virtual DbSet<ArchiveNoteType> ArchiveNoteType { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<AutoApprovalServiceConfiguration> AutoApprovalServiceConfiguration { get; set; }
        public virtual DbSet<AutoApprovalServiceStatus> AutoApprovalServiceStatus { get; set; }
        public virtual DbSet<AvalaraConfiguration> AvalaraConfiguration { get; set; }
        public virtual DbSet<BatchJob> BatchJob { get; set; }
        public virtual DbSet<BatchJobActivityType> BatchJobActivityType { get; set; }
        public virtual DbSet<BatchJobStatus> BatchJobStatus { get; set; }
        public virtual DbSet<BatchWorkOrderJob> BatchWorkOrderJob { get; set; }
        public virtual DbSet<BatchWorkOrderJobSchedule> BatchWorkOrderJobSchedule { get; set; }
        public virtual DbSet<BatchWorkOrderPending> BatchWorkOrderPending { get; set; }
        public virtual DbSet<BatchWorkOrderSource> BatchWorkOrderSource { get; set; }
        public virtual DbSet<BpoClient> BpoClient { get; set; }
        public virtual DbSet<BpoVariableCategory> BpoVariableCategory { get; set; }
        public virtual DbSet<BpoVariableValue> BpoVariableValue { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientConfigurationAttribute> ClientConfigurationAttribute { get; set; }
        public virtual DbSet<ClientDescription> ClientDescription { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<ClientVendor> ClientVendor { get; set; }
        public virtual DbSet<ClientVendorAud> ClientVendorAud { get; set; }
        public virtual DbSet<CommentType> CommentType { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<ConfigurationAttribute> ConfigurationAttribute { get; set; }
        public virtual DbSet<ConfigurationAttributeValue> ConfigurationAttributeValue { get; set; }
        public virtual DbSet<ConstructionStatusType> ConstructionStatusType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<ControlAttribute> ControlAttribute { get; set; }
        public virtual DbSet<ControlAttributeByWorkOrderStatus> ControlAttributeByWorkOrderStatus { get; set; }
        public virtual DbSet<ControlRole> ControlRole { get; set; }
        public virtual DbSet<ControlType> ControlType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CurrencyCode> CurrencyCode { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<DataAction> DataAction { get; set; }
        public virtual DbSet<DataEntity> DataEntity { get; set; }
        public virtual DbSet<DataRoleType> DataRoleType { get; set; }
        public virtual DbSet<Db> Db { get; set; }
        public virtual DbSet<DepreciationMethod> DepreciationMethod { get; set; }
        public virtual DbSet<DisplayText> DisplayText { get; set; }
        public virtual DbSet<Dnemultiplier> Dnemultiplier { get; set; }
        public virtual DbSet<Dninumber> Dninumber { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<EmailAddressEmailAddressType> EmailAddressEmailAddressType { get; set; }
        public virtual DbSet<EmailAddressType> EmailAddressType { get; set; }
        public virtual DbSet<EmailComment> EmailComment { get; set; }
        public virtual DbSet<EmailCommentConfiguration> EmailCommentConfiguration { get; set; }
        public virtual DbSet<EmailDistributionListType> EmailDistributionListType { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<ErrorNotificationEmail> ErrorNotificationEmail { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureClient> FeatureClient { get; set; }
        public virtual DbSet<FeatureConfig> FeatureConfig { get; set; }
        public virtual DbSet<FeatureConfigurationAttribute> FeatureConfigurationAttribute { get; set; }
        public virtual DbSet<FeatureFlag> FeatureFlag { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<FieldSort> FieldSort { get; set; }
        public virtual DbSet<FieldTag> FieldTag { get; set; }
        public virtual DbSet<Filter> Filter { get; set; }
        public virtual DbSet<FilterField> FilterField { get; set; }
        public virtual DbSet<FilterUser> FilterUser { get; set; }
        public virtual DbSet<FinanceValidationParameters> FinanceValidationParameters { get; set; }
        public virtual DbSet<FormControl> FormControl { get; set; }
        public virtual DbSet<HiddenWorkOrderFields> HiddenWorkOrderFields { get; set; }
        public virtual DbSet<HistoryDays> HistoryDays { get; set; }
        public virtual DbSet<IdentityProviderAssertionKey> IdentityProviderAssertionKey { get; set; }
        public virtual DbSet<IfmConnectorLastRun> IfmConnectorLastRun { get; set; }
        public virtual DbSet<ImportClientUsers> ImportClientUsers { get; set; }
        public virtual DbSet<InternalApplicationType> InternalApplicationType { get; set; }
        public virtual DbSet<InternalUserFilter> InternalUserFilter { get; set; }
        public virtual DbSet<IntlFile> IntlFile { get; set; }
        public virtual DbSet<IntlValue> IntlValue { get; set; }
        public virtual DbSet<InvoiceField> InvoiceField { get; set; }
        public virtual DbSet<InvoiceTestType> InvoiceTestType { get; set; }
        public virtual DbSet<JobScheduleStatus> JobScheduleStatus { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LineItemType> LineItemType { get; set; }
        public virtual DbSet<LocationDesignType> LocationDesignType { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<LoginType> LoginType { get; set; }
        public virtual DbSet<MarkUp> MarkUp { get; set; }
        public virtual DbSet<MarkUpArc> MarkUpArc { get; set; }
        public virtual DbSet<MarkUpLog> MarkUpLog { get; set; }
        public virtual DbSet<MarkUpRateType> MarkUpRateType { get; set; }
        public virtual DbSet<NotificationEmailContent> NotificationEmailContent { get; set; }
        public virtual DbSet<NotificationScriptVariables> NotificationScriptVariables { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<NotificationUserSettings> NotificationUserSettings { get; set; }
        public virtual DbSet<NotificationUserStatus> NotificationUserStatus { get; set; }
        public virtual DbSet<OfflineReportTickets> OfflineReportTickets { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<PartCategory> PartCategory { get; set; }
        public virtual DbSet<PasswordClientPolicy> PasswordClientPolicy { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistory { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<PreferredContactMethod> PreferredContactMethod { get; set; }
        public virtual DbSet<PropertySdtype> PropertySdtype { get; set; }
        public virtual DbSet<QueriesMetrics> QueriesMetrics { get; set; }
        public virtual DbSet<RejectReasonType> RejectReasonType { get; set; }
        public virtual DbSet<ReportFilter> ReportFilter { get; set; }
        public virtual DbSet<ReportFilterUsers> ReportFilterUsers { get; set; }
        public virtual DbSet<RoleConfigurationAttribute> RoleConfigurationAttribute { get; set; }
        public virtual DbSet<ScreenItems> ScreenItems { get; set; }
        public virtual DbSet<ScreenItemSecurity> ScreenItemSecurity { get; set; }
        public virtual DbSet<ScriptQuestionType> ScriptQuestionType { get; set; }
        public virtual DbSet<ScriptType> ScriptType { get; set; }
        public virtual DbSet<SeasonType> SeasonType { get; set; }
        public virtual DbSet<SecurityRole> SecurityRole { get; set; }
        public virtual DbSet<SkillLevel> SkillLevel { get; set; }
        public virtual DbSet<Ssoattribute> Ssoattribute { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<StateTaxType> StateTaxType { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyFrequencyType> SurveyFrequencyType { get; set; }
        public virtual DbSet<SurveyResponseType> SurveyResponseType { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<TaxRules> TaxRules { get; set; }
        public virtual DbSet<TaxType> TaxType { get; set; }
        public virtual DbSet<TimeIntervalType> TimeIntervalType { get; set; }
        public virtual DbSet<TimeZone> TimeZone { get; set; }
        public virtual DbSet<Trade> Trade { get; set; }
        public virtual DbSet<TranslationLookUps> TranslationLookUps { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClient> UserClient { get; set; }
        public virtual DbSet<UserConfigurationAttribute> UserConfigurationAttribute { get; set; }
        public virtual DbSet<UserFilter> UserFilter { get; set; }
        public virtual DbSet<UserLanguage> UserLanguage { get; set; }
        public virtual DbSet<UserLock> UserLock { get; set; }
        public virtual DbSet<UsersAllowedInMobile> UsersAllowedInMobile { get; set; }
        public virtual DbSet<UserVendor> UserVendor { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorAcceptRejectTracking> VendorAcceptRejectTracking { get; set; }
        public virtual DbSet<VendorAttachmentSettings> VendorAttachmentSettings { get; set; }
        public virtual DbSet<VendorClientAttachment> VendorClientAttachment { get; set; }
        public virtual DbSet<VendorHoliday> VendorHoliday { get; set; }
        public virtual DbSet<VendorInternational> VendorInternational { get; set; }
        public virtual DbSet<VendorMatch> VendorMatch { get; set; }
        public virtual DbSet<VendorNote> VendorNote { get; set; }
        public virtual DbSet<VendorRole> VendorRole { get; set; }
        public virtual DbSet<VendorStatusGroup> VendorStatusGroup { get; set; }
        public virtual DbSet<VendorStatusGroupMapping> VendorStatusGroupMapping { get; set; }
        public virtual DbSet<VendorTrade> VendorTrade { get; set; }
        public virtual DbSet<VendorType> VendorType { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<WorkOrderFields> WorkOrderFields { get; set; }
        public virtual DbSet<WorkOrderFieldSecurity> WorkOrderFieldSecurity { get; set; }
        public virtual DbSet<WorkOrderParentType> WorkOrderParentType { get; set; }
        public virtual DbSet<WorkOrderQueue> WorkOrderQueue { get; set; }
        public virtual DbSet<WorkOrderQueueAccess> WorkOrderQueueAccess { get; set; }
        public virtual DbSet<WorkOrderQueueCommunicationChannel> WorkOrderQueueCommunicationChannel { get; set; }
        public virtual DbSet<WorkOrderQueueDistributionAddress> WorkOrderQueueDistributionAddress { get; set; }
        public virtual DbSet<WorkOrderQueueDistributionList> WorkOrderQueueDistributionList { get; set; }
        public virtual DbSet<WorkOrderQueueHierarchy> WorkOrderQueueHierarchy { get; set; }
        public virtual DbSet<WorkOrderQueueHierarchyType> WorkOrderQueueHierarchyType { get; set; }
        public virtual DbSet<WorkOrderQueueNotification> WorkOrderQueueNotification { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationEmailAddressType> WorkOrderQueueNotificationEmailAddressType { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationSchedule> WorkOrderQueueNotificationSchedule { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationScheduleNotification> WorkOrderQueueNotificationScheduleNotification { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationScheduleNotificationWorkOrder> WorkOrderQueueNotificationScheduleNotificationWorkOrder { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationTemplate> WorkOrderQueueNotificationTemplate { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationTemplateType> WorkOrderQueueNotificationTemplateType { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus> WorkOrderQueueNotificationTemplateWorkOrderQueueStatus { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationWorkOrderQueueDistributionList> WorkOrderQueueNotificationWorkOrderQueueDistributionList { get; set; }
        public virtual DbSet<WorkOrderQueueNotificationWorkOrderQueueStatus> WorkOrderQueueNotificationWorkOrderQueueStatus { get; set; }
        public virtual DbSet<WorkOrderQueueRole> WorkOrderQueueRole { get; set; }
        public virtual DbSet<WorkOrderQueueSourceObjectType> WorkOrderQueueSourceObjectType { get; set; }
        public virtual DbSet<WorkOrderQueueStatus> WorkOrderQueueStatus { get; set; }
        public virtual DbSet<WorkOrderQueueTracking> WorkOrderQueueTracking { get; set; }
        public virtual DbSet<WorkOrderQueueType> WorkOrderQueueType { get; set; }
        public virtual DbSet<WorkOrderQueueUser> WorkOrderQueueUser { get; set; }
        public virtual DbSet<WorkOrderQueueWorkOrderQueueStatus> WorkOrderQueueWorkOrderQueueStatus { get; set; }
        public virtual DbSet<WorkOrderStatus> WorkOrderStatus { get; set; }
        public virtual DbSet<WorkOrderStatusGroup> WorkOrderStatusGroup { get; set; }
        public virtual DbSet<WorkOrderStatusHiddenFromVendor> WorkOrderStatusHiddenFromVendor { get; set; }
        public virtual DbSet<WorkOrderStatusRecall> WorkOrderStatusRecall { get; set; }
        public virtual DbSet<WorkType> WorkType { get; set; }
        public virtual DbSet<Xmllog> Xmllog { get; set; }
        public virtual DbSet<XmllogArc> XmllogArc { get; set; }
        public virtual DbSet<XmllogType> XmllogType { get; set; }
        public virtual DbSet<XmlvendorConfig> XmlvendorConfig { get; set; }

        // Unable to generate entity type for table 'dbo.alertnotificationqueue_needtosend'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.alertnotificationqueue_needtosend_nondarden'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempDardenUserPasswords'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempDardenCoordinatorPasswords'. Please see the warning messages.

        public AODBContext(DbContextOptions<AODBContext> options) 
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Action>(entity =>
            {
                entity.HasIndex(e => new { e.LanguageId, e.WorkOrderStatusId, e.NextWorkOrderStatusId, e.Name, e.DisplayText, e.Description, e.DeactivateDateTime, e.ActionId, e.Order })
                    .HasName("IX_Action_DeactivateDateTime_ActionID");

                entity.HasIndex(e => new { e.LanguageId, e.WorkOrderStatusId, e.NextWorkOrderStatusId, e.Order, e.Name, e.DisplayText, e.Description, e.DeactivateDateTime, e.ActionId })
                    .HasName("IX_Action_DeactivateDateTime_ActionID2");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextWorkOrderStatusId).HasColumnName("NextWorkOrderStatusID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SecondaryNextWorkOrderStatusId).HasColumnName("SecondaryNextWorkOrderStatusID");

                entity.Property(e => e.WorkOrderStatusId).HasColumnName("WorkOrderStatusID");
            });

            modelBuilder.Entity<ActionSecurityRole>(entity =>
            {
                entity.Property(e => e.ActionSecurityRoleId).HasColumnName("ActionSecurityRoleID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");

                entity.Property(e => e.WorkType).HasMaxLength(10);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionSecurityRole)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Action_ActionSecurityRole");
            });

            modelBuilder.Entity<ActionUser>(entity =>
            {
                entity.HasIndex(e => new { e.ActionId, e.UserId, e.DeactivateDateTime })
                    .HasName("IX_ActionUser_UserID_DeactivateDateTime");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.UserId, e.ActionId })
                    .HasName("PS_ActionUser_ActionID_DeactivateDateTime");

                entity.Property(e => e.ActionUserId).HasColumnName("ActionUserID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ActionVendor>(entity =>
            {
                entity.Property(e => e.ActionVendorId).HasColumnName("ActionVendorID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionVendor)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Action_ActionVendor");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.CommunicationId)
                    .HasName("ixAddress");

                entity.HasIndex(e => new { e.AddressTypeId, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.City, e.CommunicationId })
                    .HasName("PS_Address_CommunicationID");

                entity.HasIndex(e => new { e.CommunicationId, e.StateId })
                    .HasName("PS_Address_CommunicationID_StateID");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.City });

                entity.HasIndex(e => new { e.DeactivateDateTime, e.CommunicationId, e.StateId })
                    .HasName("PS_Address_DeactivateDateTime_CommunicationID_StateID");

                entity.HasIndex(e => new { e.City, e.StateId, e.CommunicationId, e.DeactivateDateTime })
                    .HasName("PS_Address_CommunicationID_DeactivateDateTime2");

                entity.HasIndex(e => new { e.CommunicationId, e.CountryId, e.DeactivateDateTime, e.AddressTypeId })
                    .HasName("IX_Address_AddressTypeID");

                entity.HasIndex(e => new { e.ContactId, e.StateId, e.CountryId, e.AddressTypeId, e.DeactivateDateTime })
                    .HasName("IX_Address_ContactID_StateID_CountryID");

                entity.HasIndex(e => new { e.CommunicationId, e.DeactivateDateTime, e.StateId, e.Line1, e.City, e.ZipPostalCode })
                    .HasName("IX_Address_CommunicationID");

                entity.HasIndex(e => new { e.Line1, e.City, e.ZipPostalCode, e.CommunicationId, e.DeactivateDateTime, e.StateId })
                    .HasName("PS_Address_CommunicationID_DeactivateDateTime_StateID");

                entity.HasIndex(e => new { e.AddressId, e.CommunicationId, e.StateId, e.Line1, e.Line2, e.City, e.ZipPostalCode, e.CreateUser })
                    .HasName("NCIX_Address_CreateUser");

                entity.HasIndex(e => new { e.CommunicationId, e.AddressId, e.StateId, e.AddressTypeId, e.DeactivateDateTime, e.Line1, e.City, e.ZipPostalCode })
                    .HasName("PS_Address_CommunicationID_AddressID_StateID_AddressTypeID_DeactivateDateTime");

                entity.HasIndex(e => new { e.Line1, e.Line2, e.City, e.ZipPostalCode, e.CommunicationId, e.DeactivateDateTime, e.AddressId, e.StateId })
                    .HasName("NCIX_Address_CommunicationID_DeactivateDateTime_AddressID_StateID");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.AddressTypeId, e.AddressId, e.StateId, e.CommunicationId, e.Line1, e.Line2, e.City, e.ZipPostalCode })
                    .HasName("PS_Address_DeactivateDateTime_AddressTypeID_AddressID_StateID_CommunicationID_Line1_Line2_City");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Line1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Line2).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressType");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_Address_Communication");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Address_Contact");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_State");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<AlertActionStatus>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AlertNotificationQueue>(entity =>
            {
                entity.HasIndex(e => e.CreatedDateTime);

                entity.HasIndex(e => e.Progress);

                entity.HasIndex(e => e.Subject);

                entity.HasIndex(e => new { e.CreatedDateTime, e.AlertNotificationQueueId });

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.Progress, e.CreatedDateTime })
                    .HasName("IX_AlertNotificationQueue_Progress_CreatedDateTime");

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.AlertNotificationTrackId, e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Bcc, e.ClientId, e.Progress })
                    .HasName("IX_AlertNotificationQueue_ClientID_Progress");

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.AlertNotificationTrackId, e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Bcc, e.Progress, e.ClientId })
                    .HasName("IX_AlertNotificationQueue_Progress_ClientID");

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.AlertNotificationTrackId, e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Progress, e.Bcc, e.ClientId })
                    .HasName("IX_AlertNotificationQueue_ClientID");

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.AlertNotificationTrackId, e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Bcc, e.IsHighImportance, e.Cc, e.ClientId, e.Progress })
                    .HasName("NCIX_AlertNotificationQueue_ClientID_Progress");

                entity.HasIndex(e => new { e.AlertNotificationQueueId, e.AlertNotificationTrackId, e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Progress, e.Bcc, e.IsHighImportance, e.Cc, e.ClientId })
                    .HasName("NCIX_AlertNotificationQueue_ClientID");

                entity.HasIndex(e => new { e.ToAddress, e.FromAddress, e.Subject, e.Body, e.Attachment, e.Progress, e.ModifiedDate, e.ModifiedUser, e.CreatedDateTime, e.CreatedUser, e.Bcc, e.AlertNotificationTrackId, e.ClientId, e.AlertNotificationQueueId })
                    .HasName("IX_AlertNotificationQueue_AlertNotificationTrackId_ClientID_AlertNotificationQueueId");

                entity.Property(e => e.Attachment).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(500);

                entity.Property(e => e.Body).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromAddress).HasMaxLength(50);

                entity.Property(e => e.Headers)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.ReplyTo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.ToAddress).HasMaxLength(1000);

                entity.HasOne(d => d.ProgressNavigation)
                    .WithMany(p => p.AlertNotificationQueue)
                    .HasForeignKey(d => d.Progress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertNotificationQueue_AlertActionStatus");
            });

            modelBuilder.Entity<AlertNotificationQueueAttachment>(entity =>
            {
                entity.Property(e => e.AlertNotificationQueueAttachmentId).HasColumnName("AlertNotificationQueueAttachmentID");

                entity.Property(e => e.AlertNotificationQueueId).HasColumnName("AlertNotificationQueueID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AlertNotificationQueue)
                    .WithMany(p => p.AlertNotificationQueueAttachment)
                    .HasForeignKey(d => d.AlertNotificationQueueId)
                    .HasConstraintName("FK_AlertNotificationQueueAttachment_AlertNotificationQueueID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AlertNotificationQueueAttachment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertNotificationQueueAttachment_Client");
            });

            modelBuilder.Entity<AlertNotificationRules>(entity =>
            {
                entity.HasKey(e => e.AlertRuleId);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactiveDateTime).HasColumnType("datetime");

                entity.Property(e => e.RuleMessage).IsRequired();

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AlertNotificationTemplate>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeActivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<AlertNotificationTemplatesByRulesConfig>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AlertNotificationTemplate)
                    .WithMany(p => p.AlertNotificationTemplatesByRulesConfig)
                    .HasForeignKey(d => d.AlertNotificationTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertNotificationTemplatesByRulesConfig_AlertNotificationTemplate");

                entity.HasOne(d => d.AlertRule)
                    .WithMany(p => p.AlertNotificationTemplatesByRulesConfig)
                    .HasForeignKey(d => d.AlertRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertNotificationTemplatesByRulesConfig_AlertNotificationRules");
            });

            modelBuilder.Entity<AlertNotificationTrack>(entity =>
            {
                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackKeyId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.AlertActionStatus)
                    .WithMany(p => p.AlertNotificationTrack)
                    .HasForeignKey(d => d.AlertActionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertNotificationTrack_AlertNotificationTrack");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");

                entity.Property(e => e.AnnouncementText).IsRequired();

                entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.Announcement)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .HasConstraintName("FKAnnouncements_ApplicationTypeId");
            });

            modelBuilder.Entity<ApiAccessLevel>(entity =>
            {
                entity.Property(e => e.ApiAccessLevelId).HasColumnName("ApiAccessLevelID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ApiAuthorization>(entity =>
            {
                entity.Property(e => e.ApiAuthorizationId).HasColumnName("ApiAuthorizationID");

                entity.Property(e => e.ApiAccessLevelId).HasColumnName("ApiAccessLevelID");

                entity.Property(e => e.ApiApplicationType).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuthorizationToken)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SourceDomain)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ApiAccessLevel)
                    .WithMany(p => p.ApiAuthorization)
                    .HasForeignKey(d => d.ApiAccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiAuthorization_ApiAccessLevel");
            });

            modelBuilder.Entity<ApiUsage>(entity =>
            {
                entity.HasIndex(e => new { e.ApiAuthorizationId, e.Date })
                    .HasName("NCIX_APIUsage_Date");

                entity.HasIndex(e => new { e.ApiAuthorizationId, e.Calls, e.Date })
                    .HasName("NCIX_APIUsage_Date2");

                entity.HasIndex(e => new { e.ApiAuthorizationId, e.Date, e.ApiName, e.ActionName })
                    .HasName("NCIX_ApiUsage_ApiAuthorizationID_Date_ApiName_ActionName");

                entity.Property(e => e.ApiUsageId).HasColumnName("ApiUsageID");

                entity.Property(e => e.ActingDomain)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ApiAuthorizationId).HasColumnName("ApiAuthorizationID");

                entity.Property(e => e.ApiName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.ApiAuthorization)
                    .WithMany(p => p.ApiUsage)
                    .HasForeignKey(d => d.ApiAuthorizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiUsage_ApiAuthorization");
            });

            modelBuilder.Entity<ApplicationError>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.HasIndex(e => e.ExceptionNumber);

                entity.HasIndex(e => new { e.ExceptionId, e.CreateDate })
                    .HasName("NCIX_ApplicationError_CreateDate");

                entity.Property(e => e.ApplicationName).HasMaxLength(100);

                entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionNumber).HasMaxLength(50);

                entity.Property(e => e.ObjectData).HasColumnType("xml");

                entity.Property(e => e.ServerIp)
                    .HasColumnName("ServerIP")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.ApplicationError)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .HasConstraintName("FK_ApplicationTypeId");
            });

            modelBuilder.Entity<ApplicationType>(entity =>
            {
                entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ApplicationVersionSupport>(entity =>
            {
                entity.Property(e => e.ApplicationVersionSupportId).HasColumnName("ApplicationVersionSupportID");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.IsCurrentlySupportedByApi).HasColumnName("IsCurrentlySupportedByAPI");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchiveNoteType>(entity =>
            {
                entity.Property(e => e.ArchiveNoteTypeId).HasColumnName("ArchiveNoteTypeID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AddComment).HasMaxLength(50);

                entity.Property(e => e.AddedByClientId).HasColumnName("AddedByClientID");

                entity.Property(e => e.AddedByClientRoleId).HasColumnName("AddedByClientRoleID");

                entity.Property(e => e.AddedBySecurityRoleId).HasColumnName("AddedBySecurityRoleID");

                entity.Property(e => e.AddedByUserId).HasColumnName("AddedByUserID");

                entity.Property(e => e.AddedByVendorRoleId).HasColumnName("AddedByVendorRoleID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateComment).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.Path).IsRequired();

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.AddedByClient)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.AddedByClientId)
                    .HasConstraintName("FK_Attachment_Client");

                entity.HasOne(d => d.AddedBySecurityRole)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.AddedBySecurityRoleId)
                    .HasConstraintName("FK_Attachment_SecurityRole");

                entity.HasOne(d => d.AddedByUser)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.AddedByUserId)
                    .HasConstraintName("FK_Attachment_User");

                entity.HasOne(d => d.AddedByVendorRole)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.AddedByVendorRoleId)
                    .HasConstraintName("FK_Attachment_VendorRole");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachment_Vendor");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.Property(e => e.AuditLogId).HasColumnName("AuditLogID");

                entity.Property(e => e.Command)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.DbNme)
                    .HasColumnName("DB_Nme")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoApprovalServiceConfiguration>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Tolerance).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<AutoApprovalServiceStatus>(entity =>
            {
                entity.HasKey(e => e.WorkOrderStatusId);

                entity.Property(e => e.WorkOrderStatusId)
                    .HasColumnName("WorkOrderStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.HasOne(d => d.WorkOrderStatus)
                    .WithOne(p => p.AutoApprovalServiceStatus)
                    .HasForeignKey<AutoApprovalServiceStatus>(d => d.WorkOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoApprovalServiceStatus_WorkOrderStatus");
            });

            modelBuilder.Entity<AvalaraConfiguration>(entity =>
            {
                entity.Property(e => e.AvalaraConfigurationId).HasColumnName("AvalaraConfigurationID");

                entity.Property(e => e.BaseUri)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<BatchJob>(entity =>
            {
                entity.ToTable("BatchJob", "dat");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(1000);

                entity.Property(e => e.FilePath).HasMaxLength(255);

                entity.Property(e => e.JobEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BatchJobActivityType>(entity =>
            {
                entity.ToTable("BatchJobActivityType", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BatchJobStatus>(entity =>
            {
                entity.ToTable("BatchJobStatus", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BatchWorkOrderJob>(entity =>
            {
                entity.ToTable("BatchWorkOrderJob", "dat");

                entity.Property(e => e.AlternateContact).HasMaxLength(50);

                entity.Property(e => e.Attachment).HasMaxLength(500);

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CommentEmail).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Dne).HasColumnName("DNE");

                entity.Property(e => e.EquipmentAssetTag).HasMaxLength(50);

                entity.Property(e => e.HierarchyNodeId).HasColumnName("HierarchyNodeID");

                entity.Property(e => e.HoursToRespond).HasMaxLength(10);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentWorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Priority).HasMaxLength(25);

                entity.Property(e => e.ProjectNumber).HasMaxLength(50);

                entity.Property(e => e.ProjectOther).HasMaxLength(50);

                entity.Property(e => e.RequestingContact).HasMaxLength(50);

                entity.Property(e => e.ScheduledCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");

                entity.Property(e => e.StoreNumber).HasMaxLength(10);

                entity.Property(e => e.TargetCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.TargetStartDate).HasColumnType("datetime");

                entity.Property(e => e.WorkOrderDescription).HasMaxLength(2048);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.HasOne(d => d.BatchWorkOrderJobSchedule)
                    .WithMany(p => p.BatchWorkOrderJob)
                    .HasForeignKey(d => d.BatchWorkOrderJobScheduleId)
                    .HasConstraintName("FK_BatchWorkOrderJob_BatchWorkOrderJobScheduleId");

                entity.HasOne(d => d.BatchWorkOrderPending)
                    .WithMany(p => p.BatchWorkOrderJob)
                    .HasForeignKey(d => d.BatchWorkOrderPendingId)
                    .HasConstraintName("FK_BatchWorkOrderJob_BatchWorkOrderPendingId");
            });

            modelBuilder.Entity<BatchWorkOrderJobSchedule>(entity =>
            {
                entity.ToTable("BatchWorkOrderJobSchedule", "dat");

                entity.Property(e => e.RunDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.BatchJob)
                    .WithMany(p => p.BatchWorkOrderJobSchedule)
                    .HasForeignKey(d => d.BatchJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BatchWorkOrderJobSchedule_BatchJobId");
            });

            modelBuilder.Entity<BatchWorkOrderPending>(entity =>
            {
                entity.ToTable("BatchWorkOrderPending", "dat");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.AlternateContact).HasMaxLength(50);

                entity.Property(e => e.Attachment).HasMaxLength(500);

                entity.Property(e => e.Cause).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CommentEmail).HasMaxLength(500);

                entity.Property(e => e.CostCenter).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Dne)
                    .HasColumnName("DNE")
                    .HasMaxLength(50);

                entity.Property(e => e.Emergency).HasMaxLength(50);

                entity.Property(e => e.Equipment).HasMaxLength(50);

                entity.Property(e => e.EquipmentAssetTag).HasMaxLength(50);

                entity.Property(e => e.EstimatedCompletionDuration).HasMaxLength(50);

                entity.Property(e => e.HierarchyName).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentWorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Priority).HasMaxLength(50);

                entity.Property(e => e.PriorityId).HasMaxLength(50);

                entity.Property(e => e.ProjectNumber).HasMaxLength(50);

                entity.Property(e => e.ProjectOther).HasMaxLength(50);

                entity.Property(e => e.Remedy).HasMaxLength(50);

                entity.Property(e => e.RequestCode).HasMaxLength(50);

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.RequestingContact).HasMaxLength(50);

                entity.Property(e => e.ScheduledCompleteDate).HasMaxLength(23);

                entity.Property(e => e.ScheduledStartDate).HasMaxLength(23);

                entity.Property(e => e.ServiceLocation).HasMaxLength(50);

                entity.Property(e => e.TargetCompleteDate).HasMaxLength(23);

                entity.Property(e => e.TargetStartDate).HasMaxLength(23);

                entity.Property(e => e.ValidationSummary).HasMaxLength(2000);

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(50);

                entity.Property(e => e.WbseValue).HasMaxLength(50);

                entity.Property(e => e.WorkOrderDescription).HasMaxLength(2048);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkOrderStatus).HasMaxLength(50);

                entity.Property(e => e.WorkOrderType).HasMaxLength(50);

                entity.Property(e => e.WorkType).HasMaxLength(50);

                entity.HasOne(d => d.BatchWorkOrderJobSchedule)
                    .WithMany(p => p.BatchWorkOrderPending)
                    .HasForeignKey(d => d.BatchWorkOrderJobScheduleId)
                    .HasConstraintName("FK_BatchWorkOrderPending_BatchWorkOrderJobScheduleId");

                entity.HasOne(d => d.BatchWorkOrderSource)
                    .WithMany(p => p.BatchWorkOrderPending)
                    .HasForeignKey(d => d.BatchWorkOrderSourceId)
                    .HasConstraintName("FK_BatchWorkOrderPending_BatchWorkOrderSourceId");
            });

            modelBuilder.Entity<BatchWorkOrderSource>(entity =>
            {
                entity.ToTable("BatchWorkOrderSource", "dat");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.AlternateContact).HasMaxLength(50);

                entity.Property(e => e.Attachment).HasMaxLength(500);

                entity.Property(e => e.Cause).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CommentEmail).HasMaxLength(500);

                entity.Property(e => e.CostCenter).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Dne)
                    .HasColumnName("DNE")
                    .HasMaxLength(50);

                entity.Property(e => e.Emergency).HasMaxLength(50);

                entity.Property(e => e.Equipment).HasMaxLength(50);

                entity.Property(e => e.EquipmentAssetTag).HasMaxLength(50);

                entity.Property(e => e.EstimatedCompletionDuration).HasMaxLength(50);

                entity.Property(e => e.HierarchyName).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentWorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Priority).HasMaxLength(50);

                entity.Property(e => e.ProjectNumber).HasMaxLength(50);

                entity.Property(e => e.ProjectOther).HasMaxLength(50);

                entity.Property(e => e.Remedy).HasMaxLength(50);

                entity.Property(e => e.RequestCode).HasMaxLength(50);

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.RequestingContact).HasMaxLength(50);

                entity.Property(e => e.ScheduledCompleteDate).HasMaxLength(23);

                entity.Property(e => e.ScheduledStartDate).HasMaxLength(23);

                entity.Property(e => e.ServiceLocation).HasMaxLength(50);

                entity.Property(e => e.TargetCompleteDate).HasMaxLength(23);

                entity.Property(e => e.TargetStartDate).HasMaxLength(23);

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(50);

                entity.Property(e => e.WbseValue).HasMaxLength(50);

                entity.Property(e => e.WorkOrderDescription).HasMaxLength(2048);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkOrderStatus).HasMaxLength(50);

                entity.Property(e => e.WorkOrderType).HasMaxLength(50);

                entity.Property(e => e.WorkType).HasMaxLength(50);

                entity.HasOne(d => d.BatchJob)
                    .WithMany(p => p.BatchWorkOrderSource)
                    .HasForeignKey(d => d.BatchJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BatchWorkOrderSource_BatchJobId");
            });

            modelBuilder.Entity<BpoClient>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.DeactivateDateTime })
                    .HasName("UN_name")
                    .IsUnique();

                entity.Property(e => e.BpoClientId).HasColumnName("BpoClientID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fmp1Database)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fmp1Server)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZendeskTag)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpoVariableCategory>(entity =>
            {
                entity.Property(e => e.BpoVariableCategoryId).HasColumnName("BpoVariableCategoryID");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeactivateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BpoVariableValue>(entity =>
            {
                entity.HasIndex(e => new { e.BpoVariableCategoryId, e.ValueCode, e.BpoClientId, e.DeactivateDate })
                    .HasName("AK_BpoVariableValue_BpoVariableCategoryID_ValueCode_DeactivateDate")
                    .IsUnique();

                entity.Property(e => e.BpoVariableValueId).HasColumnName("BpoVariableValueID");

                entity.Property(e => e.BpoClientId).HasColumnName("BpoClientID");

                entity.Property(e => e.BpoVariableCategoryId).HasColumnName("BpoVariableCategoryID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValueCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.BpoClient)
                    .WithMany(p => p.BpoVariableValue)
                    .HasForeignKey(d => d.BpoClientId)
                    .HasConstraintName("FK_BpoVariableValue_BpoClient");

                entity.HasOne(d => d.BpoVariableCategory)
                    .WithMany(p => p.BpoVariableValue)
                    .HasForeignKey(d => d.BpoVariableCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BpoVariableValue_VarCategory");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => new { e.DeactivateDateTime, e.Dbid });

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Abbreviation).HasMaxLength(50);

                entity.Property(e => e.AttachmentRootPath).HasMaxLength(100);

                entity.Property(e => e.AttachmentTempPath).HasMaxLength(100);

                entity.Property(e => e.ClientSiteName).HasMaxLength(50);

                entity.Property(e => e.ClientTypeId).HasColumnName("ClientTypeID");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.CompanyLanguageId).HasColumnName("CompanyLanguageID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.Dbid).HasColumnName("DBID");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DomainName).HasMaxLength(50);

                entity.Property(e => e.IdentityProviderAssertionKeyId).HasColumnName("IdentityProviderAssertionKeyID");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(10);

                entity.Property(e => e.IdpportalUrl)
                    .HasColumnName("IDPPortalUrl")
                    .HasMaxLength(250);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MobileHeaderFont).HasMaxLength(50);

                entity.Property(e => e.MobileHeaderRgb)
                    .HasColumnName("MobileHeaderRGB")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileLogoHeaderUrl)
                    .HasColumnName("MobileLogoHeaderURL")
                    .HasMaxLength(500);

                entity.Property(e => e.MobileTitleFont).HasMaxLength(50);

                entity.Property(e => e.MobileTitleRgb)
                    .HasColumnName("MobileTitleRGB")
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.ReportingServerUrl)
                    .HasColumnName("ReportingServerURL")
                    .HasMaxLength(100);

                entity.Property(e => e.SiteUrl).HasMaxLength(150);

                entity.Property(e => e.ThemeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.UrlHeaderImage).HasMaxLength(255);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_Client_Communication");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .HasConstraintName("FK_Client_CustomerType");

                entity.HasOne(d => d.Db)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.Dbid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientList_DB");

                entity.HasOne(d => d.IdentityProviderAssertionKey)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdentityProviderAssertionKeyId)
                    .HasConstraintName("FK_Client_IdentityProviderAssertionKey");
            });

            modelBuilder.Entity<ClientConfigurationAttribute>(entity =>
            {
                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientConfigurationAttribute)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientConfigurationAttribute_Client");

                entity.HasOne(d => d.ConfigurationAttribute)
                    .WithMany(p => p.ClientConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientConfigurationAttribute_ConfigurationAttribute");
            });

            modelBuilder.Entity<ClientDescription>(entity =>
            {
                entity.Property(e => e.ClientDescriptionId).HasColumnName("ClientDescriptionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2048);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientDescription)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientDescription_Client");
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.Property(e => e.ClientTypeId).HasColumnName("ClientTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<ClientVendor>(entity =>
            {
                entity.HasIndex(e => new { e.AccountNumber, e.ClientVendorId, e.VendorId })
                    .HasName("IX_ClientVendor_AccountNumber");

                entity.HasIndex(e => new { e.ClientId, e.DeactivateDateTime, e.VendorId })
                    .HasName("IX_ClientVendor_ClientID_DeactivateDateTime");

                entity.HasIndex(e => new { e.ClientId, e.VendorId, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.DeactivateDateTime, e.ClientId, e.VendorId });

                entity.HasIndex(e => new { e.VendorId, e.ClientId, e.DeactivateDateTime })
                    .HasName("PS_ClientVendor_VendorID_ClientID_DeactivateDateTime");

                entity.HasIndex(e => new { e.VendorId, e.ClientId, e.VendorCode })
                    .HasName("PS_ClientVendor_ClientID_VendorCode");

                entity.HasIndex(e => new { e.VendorId, e.VendorCode, e.ClientId })
                    .HasName("PS_ClientVendor_VendorID_VendorCode_ClientID");

                entity.HasIndex(e => new { e.AccountNumber, e.VendorId, e.ClientId, e.DeactivateDateTime })
                    .HasName("IX_ClientVendor_VendorID");

                entity.HasIndex(e => new { e.PaymentTerms, e.ClientId, e.DeactivateDateTime, e.VendorId })
                    .HasName("NCIX_ClientVendor_ClientID_DeactivateDateTime_VendorID");

                entity.HasIndex(e => new { e.PaymentTerms, e.ClientId, e.VendorId, e.DeactivateDateTime })
                    .HasName("IX_ClientVendor_ClientID_VendorID_DeactivateDateTime2");

                entity.HasIndex(e => new { e.VendorCode, e.VendorId, e.ClientId, e.DeactivateDateTime })
                    .HasName("IX_ClientVendor_VendorID_ClientID_DeactivateDateTime");

                entity.HasIndex(e => new { e.VendorCode, e.VendorId, e.DeactivateDateTime, e.ClientId })
                    .HasName("PS_ClientVendor_VendorID_DeactivateDateTime_ClientID");

                entity.HasIndex(e => new { e.AccountNumber, e.ClientId, e.DeactivateDateTime, e.ClientVendorId, e.VendorId })
                    .HasName("IX_ClientVendor_ClientID_DeactivateDateTime_ClientVendorID_VendorID");

                entity.HasIndex(e => new { e.ClientVendorId, e.ClientId, e.VendorId, e.AccountNumber, e.DeactivateDateTime })
                    .HasName("IX_ClientVendor_ClientID_VendorID_AccountNumber");

                entity.HasIndex(e => new { e.PaymentTerms, e.ClientId, e.DeactivateDateTime, e.VendorId, e.ClientVendorId })
                    .HasName("NCIX_ClientVendor_ClientID_DeactivateDateTime_VendorID_ClientVendorID");

                entity.HasIndex(e => new { e.AccountNumber, e.PaymentTerms, e.ClientId, e.DeactivateDateTime, e.VendorId, e.ClientVendorId, e.VendorCode })
                    .HasName("NCIX_ClientVendor_ClientID_DeactivateDateTime_VendorID_ClientVendorID_VendorCode");

                entity.Property(e => e.ClientVendorId).HasColumnName("ClientVendorID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PaymentTerms).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientVendor)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientVendor_Client");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ClientVendor)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientVendor_Vendor");
            });

            modelBuilder.Entity<ClientVendorAud>(entity =>
            {
                entity.ToTable("ClientVendor_aud");

                entity.Property(e => e.ClientVendorAudid).HasColumnName("ClientVendor_audid");

                entity.Property(e => e.AccountNumber).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientVendorId).HasColumnName("ClientVendorID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(100);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(100);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.PaymentTerms).HasMaxLength(100);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorCode).HasMaxLength(100);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.Property(e => e.CommentTypeId)
                    .HasColumnName("CommentTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.HasIndex(e => new { e.CommunicationId, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.DeactivateDateTime, e.CommunicationId })
                    .HasName("PS_Communication_DeactivateDateTime_CommunicationID");

                entity.HasIndex(e => new { e.CommunicationId, e.LanguageId, e.Url, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.PreviousRecordId, e.CreateUser })
                    .HasName("NCIX_Communication_CreateUser");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigurationAttribute>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigurationAttributeValue>(entity =>
            {
                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ConfigurationAttribute)
                    .WithMany(p => p.ConfigurationAttributeValue)
                    .HasForeignKey(d => d.ConfigurationAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfigurationAttributeValue_ConfigurationAttribute");
            });

            modelBuilder.Entity<ConstructionStatusType>(entity =>
            {
                entity.Property(e => e.ConstructionStatusTypeId).HasColumnName("ConstructionStatusTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.DeactivateDateTime);

                entity.HasIndex(e => new { e.ContactId, e.DeactivateDateTime })
                    .HasName("PS_Contact_ContactID_DeactivateDateTime");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.DisplayName, e.FirstName, e.LastName });

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.DeactivateDateTime, e.DisplayName })
                    .HasName("IX_Contact_DisplayName");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.DisplayName, e.DeactivateDateTime })
                    .HasName("IX_Contact_FirstName_LastName_DisplayName");

                entity.HasIndex(e => new { e.PreferredContactMethodId, e.LanguageId, e.FirstName, e.MiddleName, e.LastName, e.Title, e.DeactivateDateTime, e.ContactId, e.TimeZoneId })
                    .HasName("PS_Contact_DeactivateDateTimeContactID");

                entity.HasIndex(e => new { e.ContactId, e.TimeZoneId, e.PreferredContactMethodId, e.LanguageId, e.FirstName, e.MiddleName, e.LastName, e.DisplayName, e.Title, e.DeactivateDateTime, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.DeactivateUser })
                    .HasName("IX_Contact_DeactivateUser");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PreferredContactMethodId).HasColumnName("PreferredContactMethodID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.PreferredContactMethod)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.PreferredContactMethodId)
                    .HasConstraintName("FK_Contact_PreferredContactMethod");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_TimeZone");
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ControlTypeId).HasColumnName("ControlTypeID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.HasOne(d => d.ControlType)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.ControlTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Control_ControlType");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Control_Page");
            });

            modelBuilder.Entity<ControlAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hint).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ControlAttributeByWorkOrderStatus>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VendorRole)
                    .WithMany(p => p.ControlAttributeByWorkOrderStatus)
                    .HasForeignKey(d => d.VendorRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlAttributeByWorkOrderStatus_VendorRole");
            });

            modelBuilder.Entity<ControlRole>(entity =>
            {
                entity.HasKey(e => e.ControlUserId);

                entity.Property(e => e.ControlUserId).HasColumnName("ControlUserID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.ControlRole)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlUser_Control");
            });

            modelBuilder.Entity<ControlType>(entity =>
            {
                entity.Property(e => e.ControlTypeId).HasColumnName("ControlTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCodeId).HasColumnName("CurrencyCodeID");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.CurrencyCode)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.CurrencyCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_CurrencyCode");
            });

            modelBuilder.Entity<CurrencyCode>(entity =>
            {
                entity.Property(e => e.CurrencyCodeId).HasColumnName("CurrencyCodeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerType1)
                    .IsRequired()
                    .HasColumnName("CustomerType")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<DataAction>(entity =>
            {
                entity.ToTable("DataAction", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DataEntity>(entity =>
            {
                entity.ToTable("DataEntity", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DataRoleType>(entity =>
            {
                entity.ToTable("DataRoleType", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Db>(entity =>
            {
                entity.ToTable("DB");

                entity.Property(e => e.Dbid).HasColumnName("DBID");

                entity.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<DepreciationMethod>(entity =>
            {
                entity.Property(e => e.DepreciationMethodId).HasColumnName("DepreciationMethodID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<DisplayText>(entity =>
            {
                entity.Property(e => e.DisplayTextId).HasColumnName("DisplayTextID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.DisplayText)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DisplayText_Control");
            });

            modelBuilder.Entity<Dnemultiplier>(entity =>
            {
                entity.HasKey(e => e.DnemutiplierId);

                entity.ToTable("DNEMultiplier");

                entity.Property(e => e.DnemutiplierId).HasColumnName("DNEMutiplierID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DestinationClientId).HasColumnName("DestinationClientID");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Multiplier).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Dninumber>(entity =>
            {
                entity.ToTable("DNINumber");

                entity.Property(e => e.DninumberId).HasColumnName("DNINumberID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dnis)
                    .HasColumnName("DNIS")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Dninumber)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DNINumber_ClientID");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("IX_Emailaddress_Email");

                entity.HasIndex(e => new { e.ContactId, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.IsPrimary, e.DeactivateDateTime })
                    .HasName("IX_EmailAddress_IsPrimary");

                entity.HasIndex(e => new { e.EmailAddressId, e.CommunicationId, e.Email, e.CreateUser })
                    .HasName("NCIX_EmailAddress_CreateUser");

                entity.HasIndex(e => new { e.EmailAddressId, e.Email, e.CommunicationId, e.IsPrimary, e.DeactivateDateTime })
                    .HasName("IX_EmailAddress_CommunicationID_IsPrimary_DeactivateDateTime");

                entity.HasIndex(e => new { e.EmailAddressId, e.Email, e.IsPrimary, e.DeactivateDateTime, e.CommunicationId })
                    .HasName("PS_EmailAddress_IsPrimary_DeactivateDateTime_CommunicationID");

                entity.HasIndex(e => new { e.EmailAddressId, e.Email, e.CommunicationId, e.IsPrimary, e.DeactivateDateTime, e.ContactId })
                    .HasName("IX_EmailAddress_CommunicationID_IsPrimary_IsPrimary_ContactID");

                entity.HasIndex(e => new { e.EmailAddressId, e.CommunicationId, e.LanguageId, e.Email, e.ContactId, e.IsPrimary, e.DeactivateDateTime })
                    .HasName("PS_EmailAddress_ContactID");

                entity.HasIndex(e => new { e.ContactId, e.LanguageId, e.IsPrimary, e.Email, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.CommunicationId, e.EmailAddressId })
                    .HasName("IX_EmailAddress_CommunicationID_EmailAddressID");

                entity.Property(e => e.EmailAddressId).HasColumnName("EmailAddressID");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.EmailAddress)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_EmailAddress_Communication");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.EmailAddress)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_EmailAddress_Contact");
            });

            modelBuilder.Entity<EmailAddressEmailAddressType>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.EmailAddress)
                    .WithMany(p => p.EmailAddressEmailAddressType)
                    .HasForeignKey(d => d.EmailAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailAddressEmailAddressType_EmailAddress");

                entity.HasOne(d => d.EmailAddressType)
                    .WithMany(p => p.EmailAddressEmailAddressType)
                    .HasForeignKey(d => d.EmailAddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailAddressEmailAddressType_EmailAddressType");
            });

            modelBuilder.Entity<EmailAddressType>(entity =>
            {
                entity.Property(e => e.EmailAddressTypeId)
                    .HasColumnName("EmailAddressTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<EmailComment>(entity =>
            {
                entity.Property(e => e.EmailCommentId).HasColumnName("EmailCommentID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.From)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailCommentConfiguration>(entity =>
            {
                entity.Property(e => e.EmailCommentConfigurationId).HasColumnName("EmailCommentConfigurationID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailUniqueId).HasColumnName("EmailUniqueID");
            });

            modelBuilder.Entity<EmailDistributionListType>(entity =>
            {
                entity.Property(e => e.EmailDistributionListTypeId)
                    .HasColumnName("EmailDistributionListTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");

                entity.Property(e => e.Dbname)
                    .IsRequired()
                    .HasColumnName("DBName")
                    .HasColumnType("sysname")
                    .HasMaxLength(4000);

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ProcName).HasMaxLength(128);

                entity.Property(e => e.ProcParams).HasMaxLength(4000);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.SystemUser)
                    .HasColumnType("sysname")
                    .HasMaxLength(4000);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ErrorNotificationEmail>(entity =>
            {
                entity.HasKey(e => e.ErrorNotificationEmailsId);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FeatureClient>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FeatureClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureClient_Client");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureClient)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureClient_Feature");
            });

            modelBuilder.Entity<FeatureConfig>(entity =>
            {
                entity.HasKey(e => new { e.FeatureId, e.FeatureFlagId });

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FeatureConfigId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.FeatureFlag)
                    .WithMany(p => p.FeatureConfig)
                    .HasForeignKey(d => d.FeatureFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureConfigs_FeatureFlag");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureConfig)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureConfigs_Feature");
            });

            modelBuilder.Entity<FeatureConfigurationAttribute>(entity =>
            {
                entity.HasKey(e => new { e.FeatureId, e.ConfigurationAttributeId });

                entity.HasOne(d => d.ConfigurationAttribute)
                    .WithMany(p => p.FeatureConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureConfigurationAttribute_ConfigurationAttribute");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureConfigurationAttribute)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureConfigurationAttribute_Feature");
            });

            modelBuilder.Entity<FeatureFlag>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlagDefaultValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DatabaseName).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FieldUi)
                    .HasColumnName("FieldUI")
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Page).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<FieldSort>(entity =>
            {
                entity.Property(e => e.FieldSortId).HasColumnName("FieldSortID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.UserFilterId).HasColumnName("UserFilterID");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.FieldSort)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldSort_Field");

                entity.HasOne(d => d.UserFilter)
                    .WithMany(p => p.FieldSort)
                    .HasForeignKey(d => d.UserFilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldSort_UserFilter");
            });

            modelBuilder.Entity<FieldTag>(entity =>
            {
                entity.Property(e => e.FieldTagId).HasColumnName("FieldTagID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DatabaseField)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.Property(e => e.FilterId)
                    .HasColumnName("FilterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FilterExpression).HasMaxLength(256);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FilterField>(entity =>
            {
                entity.Property(e => e.FilterFieldId).HasColumnName("FilterFieldID");

                entity.Property(e => e.Condition).HasMaxLength(50);

                entity.Property(e => e.Conjunction).HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.ValueHigh).HasMaxLength(50);

                entity.Property(e => e.ValueLow).HasMaxLength(50);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.FilterField)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilterField_Field");
            });

            modelBuilder.Entity<FilterUser>(entity =>
            {
                entity.Property(e => e.FilterUserId)
                    .HasColumnName("FilterUserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.FilterExpression).HasMaxLength(256);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<FinanceValidationParameters>(entity =>
            {
                entity.Property(e => e.FinanceValidationParametersId).HasColumnName("FinanceValidationParametersID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.TextSearchTolerance).HasColumnType("decimal(10, 4)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FinanceValidationParameters)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinanceValidationParameters_Client");
            });

            modelBuilder.Entity<FormControl>(entity =>
            {
                entity.HasKey(e => e.ControlId);

                entity.HasIndex(e => new { e.Name, e.FilePath, e.ControlId, e.DeactivateDateTime })
                    .HasName("IX_FormControl_ControlId_DeactivateDateTime");

                entity.Property(e => e.ControlCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PageDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<HiddenWorkOrderFields>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.HiddenWorkOrderFields)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HiddenWorkOrderFields_Client");

                entity.HasOne(d => d.WorkOrderField)
                    .WithMany(p => p.HiddenWorkOrderFields)
                    .HasForeignKey(d => d.WorkOrderFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HiddenWorkOrderFields_WorkOrderFields");
            });

            modelBuilder.Entity<HistoryDays>(entity =>
            {
                entity.Property(e => e.HistoryDaysId).HasColumnName("HistoryDaysID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<IdentityProviderAssertionKey>(entity =>
            {
                entity.Property(e => e.IdentityProviderAssertionKeyId).HasColumnName("IdentityProviderAssertionKeyID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<IfmConnectorLastRun>(entity =>
            {
                entity.HasKey(e => e.IdLastRun);

                entity.Property(e => e.IfmConnectorLowesLastRun).HasColumnType("datetime");
            });

            modelBuilder.Entity<ImportClientUsers>(entity =>
            {
                entity.HasKey(e => e.IdKey);

                entity.ToTable("Import_ClientUsers");

                entity.Property(e => e.ExternalPassword)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("ProcessID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InternalApplicationType>(entity =>
            {
                entity.Property(e => e.InternalApplicationTypeId).HasColumnName("InternalApplicationTypeID");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InternalUserFilter>(entity =>
            {
                entity.Property(e => e.InternalUserFilterId).HasColumnName("InternalUserFilterID");

                entity.Property(e => e.Filter).IsRequired();

                entity.Property(e => e.InternalApplicationTypeId).HasColumnName("InternalApplicationTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sorter).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.InternalApplicationType)
                    .WithMany(p => p.InternalUserFilter)
                    .HasForeignKey(d => d.InternalApplicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalUserFilter_InternalApplicationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InternalUserFilter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalUserFilter_User");
            });

            modelBuilder.Entity<IntlFile>(entity =>
            {
                entity.ToTable("Intl_File");

                entity.Property(e => e.Culture)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourcePath)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<IntlValue>(entity =>
            {
                entity.ToTable("Intl_Value");

                entity.Property(e => e.Culture)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<InvoiceField>(entity =>
            {
                entity.Property(e => e.InvoiceFieldId).HasColumnName("InvoiceFieldID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceTestType>(entity =>
            {
                entity.Property(e => e.InvoiceTestTypeId)
                    .HasColumnName("InvoiceTestTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<JobScheduleStatus>(entity =>
            {
                entity.ToTable("JobScheduleStatus", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Translator)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<LineItemType>(entity =>
            {
                entity.Property(e => e.LineItemTypeId)
                    .HasColumnName("LineItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<LocationDesignType>(entity =>
            {
                entity.Property(e => e.LocationDesignTypeId).HasColumnName("LocationDesignTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<LoginType>(entity =>
            {
                entity.Property(e => e.LoginTypeId).HasColumnName("LoginTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.ScreenUrl)
                    .IsRequired()
                    .HasColumnName("ScreenURL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MarkUp>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.RateType, e.Rate, e.OvertimeRate, e.OverheadnProfit, e.EmgRate, e.AhRate, e.P2rate, e.P4rate, e.P8rate, e.TripCharge, e.TaxExempt, e.ClientId, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.LineItemTypeId, e.ClientAbbrev, e.DeactivateDateTime, e.RequestTypeId, e.LowerCost, e.HigherCost, e.LocationId })
                    .HasName("IX_MarkUp_LineItemTypeID_ClientAbbrev_DeactivateDateTime_RequestTypeID_LowerCost_HigherCost_LocationID");

                entity.Property(e => e.AhRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.ClientAbbrev)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.EmgRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.HigherCost).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.LineItemTypeId).HasColumnName("LineItemTypeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LowerCost)
                    .HasColumnType("decimal(14, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OverheadnProfit).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.OvertimeRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P2rate)
                    .HasColumnName("P2Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P4rate)
                    .HasColumnName("P4Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P8rate)
                    .HasColumnName("P8Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Rate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.TripCharge).HasColumnType("decimal(14, 6)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MarkUp)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_MarkUp_Client");

                entity.HasOne(d => d.LineItemType)
                    .WithMany(p => p.MarkUp)
                    .HasForeignKey(d => d.LineItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkUp_LineItemType");

                entity.HasOne(d => d.RateTypeNavigation)
                    .WithMany(p => p.MarkUp)
                    .HasForeignKey(d => d.RateType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkUp_MarkUpRateType");
            });

            modelBuilder.Entity<MarkUpArc>(entity =>
            {
                entity.ToTable("MarkUp_ARC");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AhRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.ClientAbbrev).HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.EmgRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.HigherCost).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.LineItemTypeId).HasColumnName("LineItemTypeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LowerCost).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.OverheadnProfit).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.OvertimeRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P2rate)
                    .HasColumnName("P2Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P4rate)
                    .HasColumnName("P4Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P8rate)
                    .HasColumnName("P8Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Rate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.TripCharge).HasColumnType("decimal(14, 6)");
            });

            modelBuilder.Entity<MarkUpLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AhRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.ClientAbbrev)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(100);

                entity.Property(e => e.EmgRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.HigherCost).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.LineItemTypeId).HasColumnName("LineItemTypeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LowerCost)
                    .HasColumnType("decimal(14, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Markupid).HasColumnName("MARKUPID");

                entity.Property(e => e.OverheadnProfit).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.OvertimeRate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P2rate)
                    .HasColumnName("P2Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P4rate)
                    .HasColumnName("P4Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.P8rate)
                    .HasColumnName("P8Rate")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Rate).HasColumnType("decimal(14, 6)");

                entity.Property(e => e.TripCharge).HasColumnType("decimal(14, 6)");

                entity.HasOne(d => d.Markup)
                    .WithMany(p => p.MarkUpLog)
                    .HasForeignKey(d => d.Markupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkUpLog_MarkUpLog");
            });

            modelBuilder.Entity<MarkUpRateType>(entity =>
            {
                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<NotificationEmailContent>(entity =>
            {
                entity.Property(e => e.NotificationEmailContentId)
                    .HasColumnName("NotificationEmailContentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<NotificationScriptVariables>(entity =>
            {
                entity.Property(e => e.NotificationScriptVariablesId)
                    .HasColumnName("NotificationScriptVariablesID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("NotificationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<NotificationUserSettings>(entity =>
            {
                entity.Property(e => e.NotificationUserSettingsId).HasColumnName("NotificationUserSettingsID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.NotifyOnDne).HasColumnName("NotifyOnDNE");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SendSetting).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NotificationUserStatus>(entity =>
            {
                entity.HasKey(e => e.NotificationUserStatus1);

                entity.Property(e => e.NotificationUserStatus1).HasColumnName("NotificationUserStatus");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OfflineReportTickets>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.HasIndex(e => e.ReferenceId)
                    .HasName("IX_OfflineReportTickets_ReferenceID");

                entity.HasIndex(e => new { e.Status, e.StatusDateTime, e.CreateDateTime, e.UserId })
                    .HasName("IX_OfflineReportTickets_UserId1");

                entity.HasIndex(e => new { e.ReportName, e.ReportFormat, e.FlatReport, e.Status, e.StatusDateTime, e.CreateDateTime, e.UserId })
                    .HasName("IX_OfflineReportTickets_UserId2");

                entity.HasIndex(e => new { e.TicketId, e.ReportName, e.ReportFormat, e.FlatReport, e.Status, e.StatusDateTime, e.CreateDateTime, e.UserId })
                    .HasName("IX_OfflineReportTickets_UserId3");

                entity.HasIndex(e => new { e.TicketId, e.UserId, e.UserEmail, e.OtherUsersEmails, e.ReportName, e.ReportFormat, e.FlatReport, e.Notes, e.ReferenceId, e.AttachmentPath, e.StatusDateTime, e.UserTimeZoneId, e.ClientId, e.Dbid, e.LanguageCode, e.Status, e.DeactivateDateTime })
                    .HasName("IX_OfflineReportTickets_Status_DeactivateDateTime");

                entity.HasIndex(e => new { e.TicketId, e.UserId, e.UserEmail, e.OtherUsersEmails, e.ReportName, e.ReportFormat, e.ReportFilter, e.Notes, e.ReferenceId, e.AttachmentPath, e.StatusDateTime, e.UserTimeZoneId, e.ClientId, e.Dbid, e.FlatReport, e.CreateUser, e.CreateDateTime, e.DeactivateDateTime, e.Status })
                    .HasName("IX_OfflineReportTickets_DeactivateDateTime_Status");

                entity.HasIndex(e => new { e.TicketId, e.UserId, e.UserEmail, e.OtherUsersEmails, e.ReportName, e.ReportFormat, e.FlatReport, e.Notes, e.ReferenceId, e.AttachmentPath, e.StatusDateTime, e.UserTimeZoneId, e.CreateDateTime, e.CreateUser, e.ReportFilter, e.ClientId, e.Dbid, e.LanguageCode, e.Status, e.DeactivateDateTime })
                    .HasName("IX_OfflinceReportTickets_Status_DeactivateDateTime");

                entity.Property(e => e.AttachmentPath).HasMaxLength(1000);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dbid).HasColumnName("DBId");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.OtherUsersEmails).HasMaxLength(1000);

                entity.Property(e => e.ReferenceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReportFilter)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.ReportFormat)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PartCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PasswordClientPolicy>(entity =>
            {
                entity.HasKey(e => e.PasswordPolicyId);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.PasswordStrenghtRegEx)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.Property(e => e.PasswordHistoryId).HasColumnName("PasswordHistoryID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PasswordHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PasswordHistory_User");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasIndex(e => new { e.ContactId, e.DeactivateDateTime })
                    .HasName("IX_Phone_ContactID_PhoneTypeID_DeactivateDateTime");

                entity.HasIndex(e => new { e.ContactId, e.PhoneTypeId, e.DeactivateDateTime })
                    .HasName("IX_Phone_ContactID_DeactivateDateTime");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.CommunicationId, e.PhoneTypeId })
                    .HasName("IX2_Phone_DeactivateDateTime");

                entity.HasIndex(e => new { e.Extension, e.DeactivateDateTime, e.IsPrimary, e.CommunicationId })
                    .HasName("PS_Phone_DeactivateDateTime_IsPrimary_CommunicationID");

                entity.HasIndex(e => new { e.AreaCode, e.ExchangeAndNumber, e.CommunicationId, e.DeactivateDateTime, e.PhoneTypeId })
                    .HasName("IX_Phone_CommunicationID");

                entity.HasIndex(e => new { e.CountryCode, e.AreaCode, e.CommunicationId, e.DeactivateDateTime, e.IsPrimary })
                    .HasName("PS_Phone_CommunicationID_DeactivateDateTime_IsPrimary");

                entity.HasIndex(e => new { e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.CommunicationId, e.IsPrimary, e.DeactivateDateTime })
                    .HasName("IX_Phone_CommunicationID_IsPrimary_DeactivateDateTime2");

                entity.HasIndex(e => new { e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.DeactivateDateTime, e.CommunicationId, e.IsPrimary })
                    .HasName("IX_Phone_DeactivateDateTime_CommunicationID_IsPrimary");

                entity.HasIndex(e => new { e.AreaCode, e.ExchangeAndNumber, e.Extension, e.DeactivateDateTime, e.IsPrimary, e.CommunicationId, e.PhoneId })
                    .HasName("NCIX_Phone_DeactivateDateTime_IsPrimary_CommunicationID_PhoneID");

                entity.HasIndex(e => new { e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.Extension, e.IsPrimary, e.CommunicationId, e.PhoneId })
                    .HasName("IX_Phone_IsPrimary_CommunicationID");

                entity.HasIndex(e => new { e.PhoneId, e.AreaCode, e.ExchangeAndNumber, e.Extension, e.CommunicationId, e.IsPrimary, e.DeactivateDateTime })
                    .HasName("IX_Phone_CommunicationID_IsPrimary_DeactivateDateTime");

                entity.HasIndex(e => new { e.PhoneId, e.AreaCode, e.ExchangeAndNumber, e.Extension, e.IsPrimary, e.DeactivateDateTime, e.CommunicationId })
                    .HasName("NCIX_Phone_IsPrimary_DeactivateDateTime_CommunicationID");

                entity.HasIndex(e => new { e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.CityCode, e.CommunicationId, e.DeactivateDateTime, e.IsPrimary, e.PhoneId })
                    .HasName("PS_Phone_CommunicationID_DeactivateDateTime_IsPrimary_PhoneID");

                entity.HasIndex(e => new { e.IsPrimary, e.CommunicationId, e.DeactivateDateTime, e.CountryCode, e.AreaCode, e.CityCode, e.ExchangeAndNumber, e.Extension })
                    .HasName("NCIX_Phone_IsPrimary_CommunicationID_DeactivateDateTime_CountryCode_AreaCode_CityCode_ExchangeAndNumber_Extension");

                entity.HasIndex(e => new { e.PhoneId, e.CommunicationId, e.LanguageId, e.PhoneTypeId, e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.Extension, e.DeactivateDateTime, e.IsPrimary, e.ContactId })
                    .HasName("PS_Phone_ContactID");

                entity.HasIndex(e => new { e.PhoneId, e.ContactId, e.LanguageId, e.PhoneTypeId, e.IsPrimary, e.CountryCode, e.AreaCode, e.ExchangeAndNumber, e.Extension, e.CreateDateTime, e.CreateUser, e.DeactivateDateTime, e.CommunicationId })
                    .HasName("IX_Phone_DeactivateDateTime_CommunicationID");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.CityCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ExchangeAndNumber).HasMaxLength(10);

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_Phone_Communication");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Phone_Contact");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phone_PhoneType");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<PreferredContactMethod>(entity =>
            {
                entity.Property(e => e.PreferredContactMethodId).HasColumnName("PreferredContactMethodID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<PropertySdtype>(entity =>
            {
                entity.ToTable("PropertySDType");

                entity.Property(e => e.PropertySdtypeId).HasColumnName("PropertySDTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<QueriesMetrics>(entity =>
            {
                entity.Property(e => e.FilterDtoxml)
                    .IsRequired()
                    .HasColumnName("FilterDTOXML")
                    .HasColumnType("xml");

                entity.Property(e => e.LinqQuery)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SqlQuery)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<RejectReasonType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UNQ_RejectReasonType")
                    .IsUnique();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<ReportFilter>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => new { e.UserId, e.DeactivateDateTime, e.Name });

                entity.HasIndex(e => new { e.UserId, e.Name, e.DeactivateDateTime })
                    .HasName("IX_ReportFilter_UserID_Name");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.Name, e.UserId, e.ReportFilterId })
                    .HasName("IX_ReportFilter_DeactivateDateTime_Name_UserID");

                entity.Property(e => e.ReportFilterId).HasColumnName("ReportFilterID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.FilterCriteria)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportFilter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportFilter_User");
            });

            modelBuilder.Entity<ReportFilterUsers>(entity =>
            {
                entity.HasKey(e => e.ReportFilterUserId);

                entity.HasIndex(e => e.ReportFilterId);

                entity.HasIndex(e => new { e.UserId, e.ReportFilterId });

                entity.Property(e => e.ReportFilterUserId).HasColumnName("ReportFilterUserID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReportFilterId).HasColumnName("ReportFilterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ReportFilter)
                    .WithMany(p => p.ReportFilterUsers)
                    .HasForeignKey(d => d.ReportFilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportFilterUsers_ReportFilter");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportFilterUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportFilterUsers_User");
            });

            modelBuilder.Entity<RoleConfigurationAttribute>(entity =>
            {
                entity.HasIndex(e => new { e.SecurityRoleId, e.ConfigurationAttributeId })
                    .HasName("IX_RoleConfigurationAttribute")
                    .IsUnique();

                entity.HasOne(d => d.ConfigurationAttribute)
                    .WithMany(p => p.RoleConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleConfigurationAttribute_ConfigurationAttribute1");

                entity.HasOne(d => d.ConfigurationAttributeValue)
                    .WithMany(p => p.RoleConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleConfigurationAttribute_ConfigurationAttributeValue1");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.RoleConfigurationAttribute)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleConfigurationAttribute_SecurityRole");
            });

            modelBuilder.Entity<ScreenItems>(entity =>
            {
                entity.HasKey(e => e.ScreenItemId);

                entity.Property(e => e.ScreenItemId).HasColumnName("ScreenItemID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.ScreenItems)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_ScreenItems_Page");
            });

            modelBuilder.Entity<ScreenItemSecurity>(entity =>
            {
                entity.Property(e => e.ScreenItemSecurityId).HasColumnName("ScreenItemSecurityID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ScreenItemId).HasColumnName("ScreenItemID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ScreenItemSecurity)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ScreenItemSecurity_SecurityRole");

                entity.HasOne(d => d.ScreenItem)
                    .WithMany(p => p.ScreenItemSecurity)
                    .HasForeignKey(d => d.ScreenItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScreenItemSecurity_ScreenItems");
            });

            modelBuilder.Entity<ScriptQuestionType>(entity =>
            {
                entity.Property(e => e.ScriptQuestionTypeId).HasColumnName("ScriptQuestionTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<ScriptType>(entity =>
            {
                entity.Property(e => e.ScriptTypeId).HasColumnName("ScriptTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<SeasonType>(entity =>
            {
                entity.Property(e => e.SeasonTypeId).HasColumnName("SeasonTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<SecurityRole>(entity =>
            {
                entity.Property(e => e.SecurityRoleId)
                    .HasColumnName("SecurityRoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<SkillLevel>(entity =>
            {
                entity.Property(e => e.SkillLevelId).HasColumnName("SkillLevelID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Ssoattribute>(entity =>
            {
                entity.ToTable("SSOAttribute");

                entity.Property(e => e.SsoattributeId)
                    .HasColumnName("SSOAttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => new { e.Abbreviation, e.StateId, e.DeactivateDateTime })
                    .HasName("IX_State_StateID_DeactivateDateTime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<StateTaxType>(entity =>
            {
                entity.Property(e => e.StateTaxTypeId).HasColumnName("StateTaxTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TaxTypeId).HasColumnName("TaxTypeID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.StateTaxType)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateTaxType_State");

                entity.HasOne(d => d.TaxType)
                    .WithMany(p => p.StateTaxType)
                    .HasForeignKey(d => d.TaxTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateTaxType_TaxType");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SurveyFrequencyTypeId).HasColumnName("SurveyFrequencyTypeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Survey)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survey_Client");

                entity.HasOne(d => d.SurveyFrequencyType)
                    .WithMany(p => p.Survey)
                    .HasForeignKey(d => d.SurveyFrequencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survey_SurveyFrequencyType");
            });

            modelBuilder.Entity<SurveyFrequencyType>(entity =>
            {
                entity.Property(e => e.SurveyFrequencyTypeId).HasColumnName("SurveyFrequencyTypeID");

                entity.Property(e => e.SurveyFrequencyTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SurveyResponseType>(entity =>
            {
                entity.Property(e => e.SurveyResponseTypeId).HasColumnName("SurveyResponseTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.Property(e => e.CombinedSalesTax).HasColumnType("decimal(6, 6)");

                entity.Property(e => e.CombinedUseTax).HasColumnType("decimal(6, 6)");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateSalesTax).HasColumnType("decimal(6, 6)");

                entity.Property(e => e.StateUseTax).HasColumnType("decimal(6, 6)");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_State");
            });

            modelBuilder.Entity<TaxRules>(entity =>
            {
                entity.Property(e => e.LineItemTypeId).HasColumnName("LineItemTypeID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.LineItemType)
                    .WithMany(p => p.TaxRules)
                    .HasForeignKey(d => d.LineItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRules_LineItemType");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TaxRules)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRules_State");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.Property(e => e.TaxTypeId).HasColumnName("TaxTypeID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCodeId).HasColumnName("CurrencyCodeID");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.HasOne(d => d.CurrencyCode)
                    .WithMany(p => p.TaxType)
                    .HasForeignKey(d => d.CurrencyCodeId)
                    .HasConstraintName("FK_TaxType_CurrencyCode");
            });

            modelBuilder.Entity<TimeIntervalType>(entity =>
            {
                entity.ToTable("TimeIntervalType", "dat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DaylightSavingEndDate).HasColumnType("datetime");

                entity.Property(e => e.DaylightSavingOffset).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.DaylightSavingStartDate).HasColumnType("datetime");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Offset).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasIndex(e => e.TradeId);

                entity.HasIndex(e => new { e.Name, e.TradeId })
                    .HasName("NCIX_Trade_TradeID");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<TranslationLookUps>(entity =>
            {
                entity.HasKey(e => e.TranslationsId);

                entity.HasIndex(e => new { e.TableName, e.LanguageCode, e.ColumnName, e.DeactivateDateTime, e.SourceId });

                entity.HasIndex(e => new { e.SourceId, e.Translation, e.DeactivateDateTime, e.LanguageCode, e.TableName, e.ColumnName })
                    .HasName("IX_TranslationLookUps_SourceID_TransLation");

                entity.Property(e => e.TranslationsId).HasColumnName("TranslationsID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Translation).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => new { e.LoginTypeId, e.DeactivateDateTime })
                    .HasName("PS_User_LoginTypeID");

                entity.HasIndex(e => new { e.LoginTypeId, e.UserId })
                    .HasName("NCIX_User_LoginTypeID_UserID");

                entity.HasIndex(e => new { e.UserName, e.ManagerUserId })
                    .HasName("NCIX_User_ManagerUserID");

                entity.HasIndex(e => new { e.UserName, e.UserId })
                    .HasName("IX_User_UserID");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.UserName, e.SecurityRoleId })
                    .HasName("IX_User_DeactivateDateTime");

                entity.HasIndex(e => new { e.LoginTypeId, e.DeactivateDateTime, e.SecurityRoleId })
                    .HasName("NCIX_User_LoginTypeID_DeactivateDateTime_SecurityRoleID");

                entity.HasIndex(e => new { e.UserName, e.DeactivateDateTime, e.UserId })
                    .HasName("IX_User_DeactivateDateTime_UserID");

                entity.HasIndex(e => new { e.UserName, e.Password, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.ContactId, e.DeactivateDateTime, e.Domain, e.UserId })
                    .HasName("IX_User_ContactID_DeactivateDateTime");

                entity.HasIndex(e => new { e.Domain, e.Password, e.DeactivateDateTime, e.UserName });

                entity.HasIndex(e => new { e.LoginTypeId, e.UserName, e.SecurityRoleId, e.DeactivateDateTime })
                    .HasName("IX_User_SecurityRoleID_DeactivateDateTime");

                entity.HasIndex(e => new { e.SecurityRoleId, e.ContactId, e.LoginTypeId, e.DeactivateDateTime })
                    .HasName("IX_User_LoginTypeID_DeactivateDateTime");

                entity.HasIndex(e => new { e.SecurityRoleId, e.Domain, e.UserName, e.LoginTypeId, e.UserId, e.DeactivateDateTime })
                    .HasName("PS_User_UserName_LoginTypeID_UserID_DeactivateDateTime");

                entity.HasIndex(e => new { e.UserId, e.SecurityRoleId, e.VendorRoleId, e.DeactivateDateTime, e.LoginTypeId, e.UserName })
                    .HasName("NIC_User_LoginTypeID_UserName");

                entity.HasIndex(e => new { e.UserId, e.ContactId, e.LoginTypeId, e.UserName, e.Password, e.SecurityRoleId, e.DeactivateDateTime })
                    .HasName("NCIX_User_SecurityRoleID_DeactivateDateTime");

                entity.HasIndex(e => new { e.ManagerUserId, e.SecurityRoleId, e.VendorRoleId, e.DefaultUserFilterId, e.ContactId, e.LanguageId, e.LoginTypeId, e.Password, e.ExternalPassword, e.LastLogin, e.UserBrowser, e.IsInDaylightSavingsArea, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.SyncStatus, e.SyncDateTime, e.DeactivateDateTime, e.Domain, e.UserName, e.UserId })
                    .HasName("IX_User_DeactivateDateTime_Domain");

                entity.HasIndex(e => new { e.UserId, e.ManagerUserId, e.SecurityRoleId, e.VendorRoleId, e.ContactId, e.LanguageId, e.LoginTypeId, e.Domain, e.UserName, e.Password, e.ExternalPassword, e.LastLogin, e.UserBrowser, e.IsInDaylightSavingsArea, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.SyncStatus, e.SyncDateTime, e.DefaultUserFilterId })
                    .HasName("IX_User_DefaultUserFilterID");

                entity.HasIndex(e => new { e.UserId, e.ManagerUserId, e.SecurityRoleId, e.VendorRoleId, e.DefaultUserFilterId, e.ContactId, e.LanguageId, e.LoginTypeId, e.UserName, e.Password, e.ExternalPassword, e.LastLogin, e.UserBrowser, e.IsInDaylightSavingsArea, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.SyncStatus, e.SyncDateTime, e.Domain })
                    .HasName("IX_User_Domain");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DefaultUserFilterId).HasColumnName("DefaultUserFilterID");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.ExternalPassword).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LoginTypeId).HasColumnName("LoginTypeID");

                entity.Property(e => e.ManagerUserId).HasColumnName("ManagerUserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.PwdLastResetDate).HasColumnType("date");

                entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");

                entity.Property(e => e.SyncDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserBrowser).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VendorRoleId).HasColumnName("VendorRoleID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Contact");

                entity.HasOne(d => d.LoginType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.LoginTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_LoginType");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .HasConstraintName("FK_User_SecurityRole");

                entity.HasOne(d => d.VendorRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.VendorRoleId)
                    .HasConstraintName("FK_User_VendorRole");
            });

            modelBuilder.Entity<UserClient>(entity =>
            {
                entity.HasIndex(e => new { e.DeactivateDateTime, e.EmployeeId });

                entity.HasIndex(e => new { e.ClientRoleId, e.UserId, e.UserClientId })
                    .HasName("IX_UserClient_UserID_UserClientID");

                entity.HasIndex(e => new { e.UserId, e.ClientId, e.DeactivateDateTime })
                    .HasName("IX_UserClient_UserID_ClientID_DeactivateDateTime2");

                entity.HasIndex(e => new { e.ClientId, e.DeactivateDateTime, e.DeactivateUser, e.EmployeeId });

                entity.HasIndex(e => new { e.ClientRoleId, e.UserId, e.DeactivateDateTime, e.UserClientId })
                    .HasName("PS_UserClient_UserID_DeactivateDateTime");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.ClientId, e.UserId, e.UserClientId })
                    .HasName("PS_UserClient_UserID_DeactivateDateTime_ClientID");

                entity.HasIndex(e => new { e.SpendAuthority, e.UserId, e.ClientId, e.DeactivateDateTime })
                    .HasName("IX_UserClient_UserID_ClientID_DeactivateDateTime");

                entity.HasIndex(e => new { e.UserId, e.ClientRoleId, e.ClientId, e.DeactivateDateTime })
                    .HasName("NCIX_UserClient_ClientID_DeactivateDateTime");

                entity.HasIndex(e => new { e.UserClientId, e.UserId, e.ClientId, e.UserLanguageId, e.LanguageId, e.ClientRoleId, e.SpendAuthority, e.DeactivateUser, e.CreateDateTime, e.PreviousRecordId, e.DeactivateDateTime, e.CreateUser })
                    .HasName("IX_UserClient_DeactivateDateTime_CreateUser");

                entity.HasIndex(e => new { e.UserClientId, e.UserId, e.UserLanguageId, e.LanguageId, e.ClientRoleId, e.SpendAuthority, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.ClientId })
                    .HasName("IX_UserClient_ClientID");

                entity.Property(e => e.UserClientId).HasColumnName("UserClientID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientRoleId).HasColumnName("ClientRoleID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.SpendAuthority).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLanguageId).HasColumnName("UserLanguageID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClientList_ClientList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClient)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClientList_User");
            });

            modelBuilder.Entity<UserConfigurationAttribute>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.ConfigurationAttributeId })
                    .HasName("IX_UserConfigurationAttribute")
                    .IsUnique();

                entity.HasOne(d => d.ConfigurationAttribute)
                    .WithMany(p => p.UserConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserConfigurationAttribute_ConfigurationAttribute");

                entity.HasOne(d => d.ConfigurationAttributeValue)
                    .WithMany(p => p.UserConfigurationAttribute)
                    .HasForeignKey(d => d.ConfigurationAttributeValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserConfigurationAttribute_ConfigurationAttributeValue");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserConfigurationAttribute)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserConfigurationAttribute_User");
            });

            modelBuilder.Entity<UserFilter>(entity =>
            {
                entity.Property(e => e.UserFilterId).HasColumnName("UserFilterID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.IsEta).HasColumnName("IsETA");

                entity.Property(e => e.IsPm).HasColumnName("IsPM");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFilter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFilter_User");
            });

            modelBuilder.Entity<UserLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.IsPrimary, e.DeactivateDateTime, e.UserId, e.UserLanguageId })
                    .HasName("PS_UserLanguage_UserID_ISPrimary_DeactivateDateTime");

                entity.HasIndex(e => new { e.LanguageId, e.UserId, e.IsPrimary, e.DeactivateDateTime })
                    .HasName("IX_UserLanguage_UserID_IsPrimary_DeactivateDateTime");

                entity.HasIndex(e => new { e.UserLanguageId, e.IsPrimary, e.UserId, e.LanguageId })
                    .HasName("PS_UserLanguage_LanguageID");

                entity.HasIndex(e => new { e.UserLanguageId, e.LanguageId, e.UserId, e.IsPrimary, e.DeactivateUser, e.CreateDateTime, e.PreviousRecordId, e.DeactivateDateTime, e.CreateUser })
                    .HasName("IX_UserLanguage_DeactivateDateTime_CreateUser");

                entity.Property(e => e.UserLanguageId).HasColumnName("UserLanguageID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.UserLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLanguage_Language");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLanguage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLanguage_User");
            });

            modelBuilder.Entity<UserLock>(entity =>
            {
                entity.HasKey(e => e.LockUserId);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UsersAllowedInMobile>(entity =>
            {
                entity.Property(e => e.UsersAllowedInMobileId).HasColumnName("UsersAllowedInMobileID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserVendor>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.DeactivateDateTime });

                entity.HasIndex(e => new { e.VendorId, e.DeactivateDateTime });

                entity.Property(e => e.UserVendorId).HasColumnName("UserVendorID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVendor)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserVendor_User");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.UserVendor)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserVendor_Vendor");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasIndex(e => e.DeactivateDateTime);

                entity.HasIndex(e => e.VendorId)
                    .HasName("IX_Vendor_VendorID2");

                entity.HasIndex(e => new { e.CompanyName, e.DeactivateDateTime })
                    .HasName("IX_Vendor_DeactivateDateTime_CompanyName");

                entity.HasIndex(e => new { e.CompanyName, e.VendorId });

                entity.HasIndex(e => new { e.DeactivateDateTime, e.Pin });

                entity.HasIndex(e => new { e.DeactivateDateTime, e.VendorCode });

                entity.HasIndex(e => new { e.Pin, e.DeactivateDateTime })
                    .HasName("IX_Vendor_Pin_DeactivateDateTime");

                entity.HasIndex(e => new { e.TimeZoneId, e.DeactivateDateTime })
                    .HasName("NCIX_Vendor_DeactivateDateTime");

                entity.HasIndex(e => new { e.VendorCode, e.DeactivateDateTime })
                    .HasName("IX_Vendor_Vendorcode_Deactivatedatetime");

                entity.HasIndex(e => new { e.VendorCode, e.VendorId })
                    .HasName("NCIX_Vendor_VendorCode_VendorID");

                entity.HasIndex(e => new { e.VendorId, e.ParentId })
                    .HasName("PS_Vendor_VendorID_ParentID");

                entity.HasIndex(e => new { e.VendorId, e.VendorCode })
                    .HasName("PS_Vendor_VendorCode");

                entity.HasIndex(e => new { e.CompanyName, e.VendorCode, e.VendorId })
                    .HasName("NCIX_Vendor_CompanyName_VendorCode_VendorID");

                entity.HasIndex(e => new { e.CompanyName, e.VendorId, e.DeactivateDateTime })
                    .HasName("IX_Vendor_VendorID_DeactivateDateTime");

                entity.HasIndex(e => new { e.CompanyName, e.VendorId, e.VendorCode })
                    .HasName("PS_Vendor_VendorID_VendorCode");

                entity.HasIndex(e => new { e.TimeZoneId, e.DeactivateDateTime, e.VendorCode })
                    .HasName("NCIX_DeactivateDateTime_VendorCode");

                entity.HasIndex(e => new { e.VendorId, e.VendorCode, e.ParentId })
                    .HasName("NCIX_Vendor_VendorCode_ParentID");

                entity.HasIndex(e => new { e.CompanyName, e.VendorCode, e.CommunicationId, e.VendorId })
                    .HasName("IX_Vendor_CompanyName");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.VendorId, e.ParentId, e.VendorCode })
                    .HasName("NCIX_Vendor_DeactivateDateTime_VendorID_ParentID_VendorCode");

                entity.HasIndex(e => new { e.VendorId, e.CommunicationId, e.CompanyName, e.DeactivateDateTime })
                    .HasName("NCIX_Vendor_DeactivateDateTime2");

                entity.HasIndex(e => new { e.VendorId, e.Pin, e.VendorCode, e.DeactivateDateTime })
                    .HasName("IX_Vendor_DeactivateDateTime3");

                entity.HasIndex(e => new { e.CompanyName, e.VendorCode, e.DeactivateDateTime, e.VendorId, e.CommunicationId })
                    .HasName("PS_Vendor_DeactivateDateTime_VendorID_CommunicationID");

                entity.HasIndex(e => new { e.VendorId, e.CommunicationId, e.CompanyName, e.VendorCode, e.DeactivateDateTime })
                    .HasName("IX_Vendor_DeactivateDateTime2");

                entity.HasIndex(e => new { e.VendorId, e.CompanyName, e.VendorCode, e.DeactivateDateTime, e.CommunicationId })
                    .HasName("NCIX_Vendor_VendorID_CompanyName_VendorCode_DeactivateDateTime_CommunicationID");

                entity.HasIndex(e => new { e.VendorId, e.CompanyName, e.VendorCode, e.DeactivateDateTime, e.VendorTypeId })
                    .HasName("NCIX_Vendor_DeactivateDateTime_VendorTypeID");

                entity.HasIndex(e => new { e.VendorId, e.CommunicationId, e.HistoryDaysId, e.LanguageId, e.CompanyLanguageId, e.TimeZoneId, e.CompanyName, e.Pin, e.CanEditContacts, e.CanUpdateDocuments, e.IsTrained, e.VendorCode, e.DeactivateDateTime, e.DeactivateUser, e.CreateDateTime, e.CreateUser, e.PreviousRecordId, e.VendorTypeId, e.PaymentMethodId, e.ParentId })
                    .HasName("IX_Vendor_ParentID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AttachmentFolderName).HasMaxLength(50);

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.CompanyLanguageId).HasColumnName("CompanyLanguageID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Ein)
                    .HasColumnName("EIN")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryDaysId).HasColumnName("HistoryDaysID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorTypeId).HasColumnName("VendorTypeID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Vendor_Vendor1");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Vendor)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Vendor_PaymentMethod");

                entity.HasOne(d => d.VendorType)
                    .WithMany(p => p.Vendor)
                    .HasForeignKey(d => d.VendorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendor_VendorType");
            });

            modelBuilder.Entity<VendorAcceptRejectTracking>(entity =>
            {
                entity.Property(e => e.AcceptDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DeactiveDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.RejectDateTime).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RejectReasonId).HasColumnName("RejectReasonID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<VendorAttachmentSettings>(entity =>
            {
                entity.Property(e => e.VendorAttachmentSettingsId).HasColumnName("VendorAttachmentSettingsID");

                entity.Property(e => e.AttachmentRootPath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<VendorClientAttachment>(entity =>
            {
                entity.Property(e => e.VendorClientAttachmentId).HasColumnName("VendorClientAttachmentID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.VendorClientAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorClientAttachment_Attachment");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.VendorClientAttachment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorClientAttachment_Client");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorClientAttachment)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorClientAttachment_Vendor");
            });

            modelBuilder.Entity<VendorHoliday>(entity =>
            {
                entity.Property(e => e.VendorHolidayId).HasColumnName("VendorHolidayID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorHoliday)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Holiday_Vendor");
            });

            modelBuilder.Entity<VendorInternational>(entity =>
            {
                entity.HasIndex(e => new { e.DeactivateDateTime, e.VendorId, e.ClientId })
                    .HasName("NCIX_VendorInternational_DeactivateDateTime_VendorID_ClientID");

                entity.HasIndex(e => new { e.AccountNumber, e.SequenceNumber, e.TaxNumber, e.DeactivateDateTime, e.VendorId, e.ClientId, e.VendorInternationalId, e.CountryId })
                    .HasName("NCIX_VendorInternational_DeactivateDateTime_VendorID_ClientID_VendorInternationalID_CountryID");

                entity.Property(e => e.VendorInternationalId).HasColumnName("VendorInternationalID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCodeId).HasColumnName("CurrencyCodeID");

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.SequenceNumber).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.VendorInternational)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorInternational_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.VendorInternational)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorInternational_Country");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorInternational)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorInternational_Vendor");
            });

            modelBuilder.Entity<VendorMatch>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Pilot2VendorCode });

                entity.Property(e => e.Pilot2VendorCode).HasMaxLength(50);

                entity.Property(e => e.ClientVendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorMatchId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VendorNote>(entity =>
            {
                entity.HasIndex(e => new { e.VendorNoteId, e.Note, e.LanguageId, e.VendorId, e.DeactivateDateTime })
                    .HasName("IX_VendorNote_VendorID_DeactivateDateTime");

                entity.Property(e => e.VendorNoteId).HasColumnName("VendorNoteID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Note).HasColumnType("nvarchar(max)");

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<VendorRole>(entity =>
            {
                entity.HasIndex(e => new { e.DeactivateDateTime, e.VendorRoleId, e.Name })
                    .HasName("IX_VendorRole");

                entity.Property(e => e.VendorRoleId).HasColumnName("VendorRoleID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<VendorStatusGroup>(entity =>
            {
                entity.Property(e => e.VendorStatusGroupId).HasColumnName("VendorStatusGroupID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<VendorStatusGroupMapping>(entity =>
            {
                entity.Property(e => e.VendorStatusGroupMappingId).HasColumnName("VendorStatusGroupMappingID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.VendorStatusGroupId).HasColumnName("VendorStatusGroupID");

                entity.Property(e => e.WorkOrderStatusId).HasColumnName("WorkOrderStatusID");

                entity.HasOne(d => d.VendorStatusGroup)
                    .WithMany(p => p.VendorStatusGroupMapping)
                    .HasForeignKey(d => d.VendorStatusGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorStatusGroupMapping_VendorStatusGroup");

                entity.HasOne(d => d.WorkOrderStatus)
                    .WithMany(p => p.VendorStatusGroupMapping)
                    .HasForeignKey(d => d.WorkOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorStatusGroupMapping_WorkOrderStatus");
            });

            modelBuilder.Entity<VendorTrade>(entity =>
            {
                entity.HasIndex(e => new { e.VendorId, e.DeactivateDateTime })
                    .HasName("IX_Phone_CommunicationID");

                entity.HasIndex(e => new { e.DeactivateDateTime, e.TradeId, e.VendorId })
                    .HasName("IX_VendorTrade_DeactivateDateTime_TradeID");

                entity.Property(e => e.VendorTradeId).HasColumnName("VendorTradeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.VendorTrade)
                    .HasForeignKey(d => d.TradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorTrade_Trade");
            });

            modelBuilder.Entity<VendorType>(entity =>
            {
                entity.Property(e => e.VendorTypeId)
                    .HasColumnName("VendorTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Beversion)
                    .IsRequired()
                    .HasColumnName("BEVersion")
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.Boversion)
                    .IsRequired()
                    .HasColumnName("BOVersion")
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateUser)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Dbfversion)
                    .IsRequired()
                    .HasColumnName("DBFVersion")
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.Dbversion)
                    .IsRequired()
                    .HasColumnName("DBVersion")
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.WebVersion)
                    .IsRequired()
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.Wsfversion)
                    .IsRequired()
                    .HasColumnName("WSFVersion")
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.Wsversion)
                    .IsRequired()
                    .HasColumnName("WSVersion")
                    .HasColumnType("nchar(15)");
            });

            modelBuilder.Entity<WorkOrderFields>(entity =>
            {
                entity.HasKey(e => e.WorkOrderFieldId);

                entity.Property(e => e.WorkOrderFieldId).HasColumnName("WorkOrderFieldID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Descriptions).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkOrderFieldSecurity>(entity =>
            {
                entity.Property(e => e.WorkOrderFieldSecurityId).HasColumnName("WorkOrderFieldSecurityID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkOrderFieldId).HasColumnName("WorkOrderFieldID");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.WorkOrderFieldSecurity)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .HasConstraintName("FK_WorkOrderFieldSecurity_SecurityRole");

                entity.HasOne(d => d.WorkOrderField)
                    .WithMany(p => p.WorkOrderFieldSecurity)
                    .HasForeignKey(d => d.WorkOrderFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderFieldSecurity_WorkOrderFields");
            });

            modelBuilder.Entity<WorkOrderParentType>(entity =>
            {
                entity.Property(e => e.WorkOrderParentTypeId).HasColumnName("WorkOrderParentTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueue>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueId).HasColumnName("WorkOrderQueueID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Filters).HasColumnType("xml");

                entity.Property(e => e.GroupByProperty).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkOrderQueueHierarchyId).HasColumnName("WorkOrderQueueHierarchyID");

                entity.Property(e => e.WorkOrderQueueTypeId)
                    .HasColumnName("WorkOrderQueueTypeID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.WorkOrderQueueHierarchy)
                    .WithMany(p => p.WorkOrderQueue)
                    .HasForeignKey(d => d.WorkOrderQueueHierarchyId)
                    .HasConstraintName("FK_WorkOrderQueue_WorkOrderQueueHierarchy");

                entity.HasOne(d => d.WorkOrderQueueType)
                    .WithMany(p => p.WorkOrderQueue)
                    .HasForeignKey(d => d.WorkOrderQueueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueue_WorkOrderQueueType");
            });

            modelBuilder.Entity<WorkOrderQueueAccess>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueAccessId).HasColumnName("WorkOrderQueueAccessID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkOrderQueueRoleId).HasColumnName("WorkOrderQueueRoleID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkOrderQueueAccess)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueAccess_User");

                entity.HasOne(d => d.WorkOrderQueueRole)
                    .WithMany(p => p.WorkOrderQueueAccess)
                    .HasForeignKey(d => d.WorkOrderQueueRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueAccess_WorkOrderQueueRole");
            });

            modelBuilder.Entity<WorkOrderQueueCommunicationChannel>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueCommunicationChannelId).HasColumnName("WorkOrderQueueCommunicationChannelID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueDistributionAddress>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueDistributionAddressId).HasColumnName("WorkOrderQueueDistributionAddressID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueDistributionListId).HasColumnName("WorkOrderQueueDistributionListID");

                entity.HasOne(d => d.WorkOrderQueueDistributionList)
                    .WithMany(p => p.WorkOrderQueueDistributionAddress)
                    .HasForeignKey(d => d.WorkOrderQueueDistributionListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueDistributionAddress_WorkOrderQueueDistributionList");
            });

            modelBuilder.Entity<WorkOrderQueueDistributionList>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueDistributionListId).HasColumnName("WorkOrderQueueDistributionListID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueCommunicationChannelId).HasColumnName("WorkOrderQueueCommunicationChannelID");

                entity.HasOne(d => d.WorkOrderQueueCommunicationChannel)
                    .WithMany(p => p.WorkOrderQueueDistributionList)
                    .HasForeignKey(d => d.WorkOrderQueueCommunicationChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueDistributionList_WorkOrderQueueCommunicationChannel");
            });

            modelBuilder.Entity<WorkOrderQueueHierarchy>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueHierarchyId).HasColumnName("WorkOrderQueueHierarchyID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueHierarchyParentId).HasColumnName("WorkOrderQueueHierarchyParentID");

                entity.Property(e => e.WorkOrderQueueHierarchyTypeId).HasColumnName("WorkOrderQueueHierarchyTypeID");

                entity.HasOne(d => d.WorkOrderQueueHierarchyParent)
                    .WithMany(p => p.InverseWorkOrderQueueHierarchyParent)
                    .HasForeignKey(d => d.WorkOrderQueueHierarchyParentId)
                    .HasConstraintName("FK_WorkOrderQueueHierarchy_WorkOrderQueueHierarchy");

                entity.HasOne(d => d.WorkOrderQueueHierarchyType)
                    .WithMany(p => p.WorkOrderQueueHierarchy)
                    .HasForeignKey(d => d.WorkOrderQueueHierarchyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueHierarchy_WorkOrderQueueHierarchyType");
            });

            modelBuilder.Entity<WorkOrderQueueHierarchyType>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueHierarchyTypeId).HasColumnName("WorkOrderQueueHierarchyTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueNotification>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationId).HasColumnName("WorkOrderQueueNotificationID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("EmailCC")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Recurrence).HasColumnType("xml");

                entity.Property(e => e.WorkOrderQueueHierarchyId).HasColumnName("WorkOrderQueueHierarchyID");

                entity.Property(e => e.WorkOrderQueueNotificationTemplateId).HasColumnName("WorkOrderQueueNotificationTemplateID");

                entity.Property(e => e.WorkOrderQueueSourceObjectId).HasColumnName("WorkOrderQueueSourceObjectID");

                entity.Property(e => e.WorkOrderQueueSourceObjectTypeId).HasColumnName("WorkOrderQueueSourceObjectTypeID");

                entity.HasOne(d => d.WorkOrderQueueHierarchy)
                    .WithMany(p => p.WorkOrderQueueNotification)
                    .HasForeignKey(d => d.WorkOrderQueueHierarchyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotification_WorkOrderQueueHierarchy");

                entity.HasOne(d => d.WorkOrderQueueNotificationTemplate)
                    .WithMany(p => p.WorkOrderQueueNotification)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotification_WorkOrderQueueNotificationTemplate");

                entity.HasOne(d => d.WorkOrderQueueSourceObjectType)
                    .WithMany(p => p.WorkOrderQueueNotification)
                    .HasForeignKey(d => d.WorkOrderQueueSourceObjectTypeId)
                    .HasConstraintName("FK_WorkOrderQueueNotification_WorkOrderQueueSourceObjectType");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationEmailAddressType>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationEmailAddressTypeId).HasColumnName("WorkOrderQueueNotificationEmailAddressTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.EmailAddressTypeId).HasColumnName("EmailAddressTypeID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueNotificationId).HasColumnName("WorkOrderQueueNotificationID");

                entity.HasOne(d => d.EmailAddressType)
                    .WithMany(p => p.WorkOrderQueueNotificationEmailAddressType)
                    .HasForeignKey(d => d.EmailAddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationEmailAddressType_EmailAddressType");

                entity.HasOne(d => d.WorkOrderQueueNotification)
                    .WithMany(p => p.WorkOrderQueueNotificationEmailAddressType)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationEmailAddressType_WorkOrderQueueNotification");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationSchedule>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationScheduleId).HasColumnName("WorkOrderQueueNotificationScheduleID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ErrorDetails).IsUnicode(false);

                entity.Property(e => e.ExecutionDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkOrderQueueNotificationId).HasColumnName("WorkOrderQueueNotificationID");

                entity.HasOne(d => d.WorkOrderQueueNotification)
                    .WithMany(p => p.WorkOrderQueueNotificationSchedule)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationSchedule_WorkOrderQueueNotification");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationScheduleNotification>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationScheduleNotificationId).HasColumnName("WorkOrderQueueNotificationScheduleNotificationID");

                entity.Property(e => e.AlertNotificationQueueId).HasColumnName("AlertNotificationQueueID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueNotificationScheduleId).HasColumnName("WorkOrderQueueNotificationScheduleID");

                entity.HasOne(d => d.AlertNotificationQueue)
                    .WithMany(p => p.WorkOrderQueueNotificationScheduleNotification)
                    .HasForeignKey(d => d.AlertNotificationQueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationScheduleNotification_WorkOrderQueueNotificationSchedule");

                entity.HasOne(d => d.WorkOrderQueueNotificationSchedule)
                    .WithMany(p => p.WorkOrderQueueNotificationScheduleNotification)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationScheduleNotification_AlertNotficiationQueue");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationScheduleNotificationWorkOrder>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationScheduleNotificationWorkOrderId).HasColumnName("WorkOrderQueueNotificationScheduleNotificationWorkOrderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderNumber)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.WorkOrderQueueNotificationScheduleNotificationId).HasColumnName("WorkOrderQueueNotificationScheduleNotificationID");

                entity.HasOne(d => d.WorkOrderQueueNotificationScheduleNotification)
                    .WithMany(p => p.WorkOrderQueueNotificationScheduleNotificationWorkOrder)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationScheduleNotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationScheduleNotificationWorkOrder_WorkOrderQueueNotificationScheduleNotification");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationTemplate>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationTemplateId).HasColumnName("WorkOrderQueueNotificationTemplateID");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.MaxRecordsToReturn).HasDefaultValueSql("((50))");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.WorkOrderQueueHierarchyId).HasColumnName("WorkOrderQueueHierarchyID");

                entity.Property(e => e.WorkOrderQueueNotificationTemplateTypeId)
                    .HasColumnName("WorkOrderQueueNotificationTemplateTypeID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.WorkOrderQueueHierarchy)
                    .WithMany(p => p.WorkOrderQueueNotificationTemplate)
                    .HasForeignKey(d => d.WorkOrderQueueHierarchyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationTemplate_WorkOrderQueueDistributionList");

                entity.HasOne(d => d.WorkOrderQueueNotificationTemplateType)
                    .WithMany(p => p.WorkOrderQueueNotificationTemplate)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationTemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationTemplate_WorkOrderQueueNotificationTemplateType");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationTemplateType>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationTemplateTypeId)
                    .HasColumnName("WorkOrderQueueNotificationTemplateTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationTemplateWorkOrderQueueStatus>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationTemplateWorkOrderQueueStatusId).HasColumnName("WorkOrderQueueNotificationTemplateWorkOrderQueueStatusID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueNotificationTemplateId).HasColumnName("WorkOrderQueueNotificationTemplateID");

                entity.Property(e => e.WorkOrderQueueStatusId).HasColumnName("WorkOrderQueueStatusID");

                entity.HasOne(d => d.WorkOrderQueueNotificationTemplate)
                    .WithMany(p => p.WorkOrderQueueNotificationTemplateWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationTemplateWorkOrderQueueStatus_WorkOrderQueueNotificationTemplate");

                entity.HasOne(d => d.WorkOrderQueueStatus)
                    .WithMany(p => p.WorkOrderQueueNotificationTemplateWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationTemplateWorkOrderQueueStatus_WorkOrderQueueStatus");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationWorkOrderQueueDistributionList>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationWorkOrderQueueDistributionListId).HasColumnName("WorkOrderQueueNotificationWorkOrderQueueDistributionListID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueDistributionListId).HasColumnName("WorkOrderQueueDistributionListID");

                entity.Property(e => e.WorkOrderQueueNotificationId).HasColumnName("WorkOrderQueueNotificationID");

                entity.HasOne(d => d.WorkOrderQueueDistributionList)
                    .WithMany(p => p.WorkOrderQueueNotificationWorkOrderQueueDistributionList)
                    .HasForeignKey(d => d.WorkOrderQueueDistributionListId)
                    .HasConstraintName("FK_WorkOrderQueueNotificationWorkOrderQueueDistributionList_WorkOrderQueueDistributionList");

                entity.HasOne(d => d.WorkOrderQueueNotification)
                    .WithMany(p => p.WorkOrderQueueNotificationWorkOrderQueueDistributionList)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationWorkOrderQueueDistributionList_WorkOrderQueueNotification");
            });

            modelBuilder.Entity<WorkOrderQueueNotificationWorkOrderQueueStatus>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueNotificationWorkOrderQueueStatusId).HasColumnName("WorkOrderQueueNotificationWorkOrderQueueStatusID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueNotificationId).HasColumnName("WorkOrderQueueNotificationID");

                entity.Property(e => e.WorkOrderQueueStatusId).HasColumnName("WorkOrderQueueStatusID");

                entity.HasOne(d => d.WorkOrderQueueNotification)
                    .WithMany(p => p.WorkOrderQueueNotificationWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueNotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueNotificationWorkOrderQueueStatus_WorkOrderQueueNotification");

                entity.HasOne(d => d.WorkOrderQueueStatus)
                    .WithMany(p => p.WorkOrderQueueNotificationWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueStatusId)
                    .HasConstraintName("FK_WorkOrderQueueNotificationWorkOrderQueueStatus_WorkOrderQueueStatus");
            });

            modelBuilder.Entity<WorkOrderQueueRole>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueRoleId).HasColumnName("WorkOrderQueueRoleID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkOrderQueueSourceObjectType>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueSourceObjectTypeId).HasColumnName("WorkOrderQueueSourceObjectTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueStatus>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueStatusId).HasColumnName("WorkOrderQueueStatusID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueTracking>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueTrackingId).HasColumnName("WorkOrderQueueTrackingID");

                entity.Property(e => e.AssignedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnName("WorkOrderID")
                    .HasMaxLength(268)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderQueueId).HasColumnName("WorkOrderQueueID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkOrderQueueTracking)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WorkOrderQueueTracking_User");

                entity.HasOne(d => d.WorkOrderQueue)
                    .WithMany(p => p.WorkOrderQueueTracking)
                    .HasForeignKey(d => d.WorkOrderQueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueTracking_WorkOrderQueue");
            });

            modelBuilder.Entity<WorkOrderQueueType>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueTypeId).HasColumnName("WorkOrderQueueTypeID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderQueueUser>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueUserId).HasColumnName("WorkOrderQueueUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkOrderQueueId).HasColumnName("WorkOrderQueueID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkOrderQueueUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueUser_User");

                entity.HasOne(d => d.WorkOrderQueue)
                    .WithMany(p => p.WorkOrderQueueUser)
                    .HasForeignKey(d => d.WorkOrderQueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueUser_WorkOrderQueue");
            });

            modelBuilder.Entity<WorkOrderQueueWorkOrderQueueStatus>(entity =>
            {
                entity.Property(e => e.WorkOrderQueueWorkOrderQueueStatusId).HasColumnName("WorkOrderQueueWorkOrderQueueStatusID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderQueueId).HasColumnName("WorkOrderQueueID");

                entity.Property(e => e.WorkOrderQueueStatusId).HasColumnName("WorkOrderQueueStatusID");

                entity.HasOne(d => d.WorkOrderQueue)
                    .WithMany(p => p.WorkOrderQueueWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueWorkOrderQueueStatus_WorkOrderQueue");

                entity.HasOne(d => d.WorkOrderQueueStatus)
                    .WithMany(p => p.WorkOrderQueueWorkOrderQueueStatus)
                    .HasForeignKey(d => d.WorkOrderQueueStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderQueueWorkOrderQueueStatus_WorkOrderQueueStatus");
            });

            modelBuilder.Entity<WorkOrderStatus>(entity =>
            {
                entity.Property(e => e.WorkOrderStatusId)
                    .HasColumnName("WorkOrderStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayColor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayColorImageUrl)
                    .IsRequired()
                    .HasColumnName("DisplayColorImageURL")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderStatusGroupId).HasColumnName("WorkOrderStatusGroupID");

                entity.HasOne(d => d.WorkOrderStatusGroup)
                    .WithMany(p => p.WorkOrderStatus)
                    .HasForeignKey(d => d.WorkOrderStatusGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderStatus_WorkOrderStatusGroup");
            });

            modelBuilder.Entity<WorkOrderStatusGroup>(entity =>
            {
                entity.Property(e => e.WorkOrderStatusGroupId).HasColumnName("WorkOrderStatusGroupID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<WorkOrderStatusHiddenFromVendor>(entity =>
            {
                entity.HasKey(e => e.VendorWorkOrdderStatusId);

                entity.Property(e => e.VendorWorkOrdderStatusId).HasColumnName("VendorWorkOrdderStatusID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.WorkOrderStatusId).HasColumnName("WorkOrderStatusID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WorkOrderStatusHiddenFromVendor)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderStatusHiddenFromVendor_Client");

                entity.HasOne(d => d.WorkOrderStatus)
                    .WithMany(p => p.WorkOrderStatusHiddenFromVendor)
                    .HasForeignKey(d => d.WorkOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderStatusHiddenFromVendor_WorkOrderStatus");
            });

            modelBuilder.Entity<WorkOrderStatusRecall>(entity =>
            {
                entity.Property(e => e.WorkOrderStatusRecallId).HasColumnName("WorkOrderStatusRecallID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");

                entity.Property(e => e.WorkOrderStatusId).HasColumnName("WorkOrderStatusID");

                entity.HasOne(d => d.WorkOrderStatus)
                    .WithMany(p => p.WorkOrderStatusRecall)
                    .HasForeignKey(d => d.WorkOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderStatusRecall_WorkOrderStatus");
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.HasIndex(e => e.WorkTypeId);

                entity.HasIndex(e => new { e.Code, e.WorkTypeId })
                    .HasName("NCIX_WorkType_WorkTypeID3");

                entity.HasIndex(e => new { e.Name, e.WorkTypeId })
                    .HasName("NCIX_WorkType_WorkTypeID");

                entity.HasIndex(e => new { e.WorkTypeId, e.Name })
                    .HasName("NCIX_WorkType_WorkTypeID_Name");

                entity.HasIndex(e => new { e.Code, e.Name, e.WorkTypeId })
                    .HasName("NCIX_WorkType_WorkTypeID2");

                entity.HasIndex(e => new { e.Name, e.DeactivateDateTime, e.WorkTypeId })
                    .HasName("NCIX_WorkType_DeactivateDateTime_WorkTypeID");

                entity.Property(e => e.WorkTypeId).HasColumnName("WorkTypeID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeactivateUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousRecordId).HasColumnName("PreviousRecordID");
            });

            modelBuilder.Entity<Xmllog>(entity =>
            {
                entity.ToTable("XMLLog");

                entity.HasIndex(e => new { e.CreateDateTime, e.XmllogId })
                    .HasName("IX_XMLLog_CreateDateTime_XMLogId");

                entity.HasIndex(e => new { e.XmllogId, e.CreateDateTime })
                    .HasName("IX_XMLLog_CreateDateTime");

                entity.HasIndex(e => new { e.WorkOrderId, e.ClientId, e.Status })
                    .HasName("IX_XMLLog_ClientID_Status");

                entity.HasIndex(e => new { e.WorkOrderId, e.Status, e.ClientId })
                    .HasName("IX_XMLLog_ClientID");

                entity.HasIndex(e => new { e.XmllogId, e.CreateDateTime, e.WorkOrderId })
                    .HasName("IX_XMLLog_WorkOrderID2");

                entity.HasIndex(e => new { e.XmllogId, e.WorkOrderId, e.Xml, e.XmllogTypeId })
                    .HasName("IX_XMLLog_XMLLogTypeID");

                entity.HasIndex(e => new { e.XmllogId, e.XmllogTypeId, e.CreateDateTime, e.WorkOrderId })
                    .HasName("IX_XMLLog_WorkOrderID");

                entity.HasIndex(e => new { e.XmllogId, e.VendorId, e.Xml, e.XmlResult, e.CreateDateTime, e.From, e.ClientId, e.WorkOrderId, e.XmllogTypeId, e.Status })
                    .HasName("IX_XMLLog_ClientID_WorkOrderID");

                entity.HasIndex(e => new { e.XmllogId, e.VendorId, e.WorkOrderId, e.Xml, e.XmlResult, e.CreateDateTime, e.UserId, e.UserName, e.Status, e.XmllogTypeId, e.ClientId })
                    .HasName("PS_XMLLog_ClientID_Status");

                entity.HasIndex(e => new { e.XmllogId, e.VendorId, e.WorkOrderId, e.Xml, e.XmlResult, e.CreateDateTime, e.UserId, e.UserName, e.RetryCount, e.ClientId, e.XmllogTypeId, e.Status })
                    .HasName("IX_XMLLog_ClientID_XMLLogTypeID_Status");

                entity.HasIndex(e => new { e.XmllogId, e.ClientId, e.VendorId, e.WorkOrderId, e.DbId, e.XmllogTypeId, e.Xml, e.XmlResult, e.Status, e.CreateDateTime, e.ExceptionId, e.UserId, e.From, e.To, e.UserName })
                    .HasName("IX_XMLLog_UserName");

                entity.Property(e => e.XmllogId).HasColumnName("XMLLogID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DbId).HasColumnName("DbID");

                entity.Property(e => e.From).HasMaxLength(50);

                entity.Property(e => e.To).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.XmlResult).HasColumnType("nvarchar(max)");

                entity.Property(e => e.XmllogTypeId).HasColumnName("XMLLogTypeID");

                entity.HasOne(d => d.XmllogType)
                    .WithMany(p => p.Xmllog)
                    .HasForeignKey(d => d.XmllogTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XMLLog_XMLLogType");
            });

            modelBuilder.Entity<XmllogArc>(entity =>
            {
                entity.HasKey(e => e.XmllogId);

                entity.ToTable("XMLLog_ARC");

                entity.HasIndex(e => new { e.XmllogId, e.ClientId, e.VendorId, e.DbId, e.XmllogTypeId, e.Xml, e.XmlResult, e.Status, e.CreateDateTime, e.ExceptionId, e.UserId, e.UserName, e.From, e.To, e.RetryCount, e.TransmittedData, e.WorkOrderId })
                    .HasName("NCIX_XMLLog_ARC_WorkOrderID");

                entity.Property(e => e.XmllogId).HasColumnName("XMLLogID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DbId).HasColumnName("DbID");

                entity.Property(e => e.From)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransmittedData).HasColumnType("varchar(max)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.XmlResult).HasColumnType("varchar(max)");

                entity.Property(e => e.XmllogTypeId).HasColumnName("XMLLogTypeID");
            });

            modelBuilder.Entity<XmllogType>(entity =>
            {
                entity.HasKey(e => e.LogTypeId);

                entity.ToTable("XMLLogType");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<XmlvendorConfig>(entity =>
            {
                entity.ToTable("XMLVendorConfig");

                entity.Property(e => e.XmlvendorConfigId).HasColumnName("XMLVendorConfigID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthenticationPin)
                    .HasColumnName("AuthenticationPIN")
                    .HasMaxLength(50);

                entity.Property(e => e.AuthenticationUserName).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FtpFolder).HasMaxLength(200);

                entity.Property(e => e.FtpHost)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FtpPassword).HasMaxLength(50);

                entity.Property(e => e.FtpPort)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FtpRootPath).HasMaxLength(50);

                entity.Property(e => e.FtpUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetUrl)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.XmlvendorConfig)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XMLVendorConfig_Client");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.XmlvendorConfig)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XMLVendorConfig_Vendor");

                entity.HasOne(d => d.XmlLogType)
                    .WithMany(p => p.XmlvendorConfig)
                    .HasForeignKey(d => d.XmlLogTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XMLVendorConfig_XMLLogType");
            });
        }
    }
}
