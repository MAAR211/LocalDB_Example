using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Database_Example_3.Models;

public partial class Hrrav3GeNextPreprodContext : DbContext
{
    public Hrrav3GeNextPreprodContext()
    {
    }

    public Hrrav3GeNextPreprodContext(DbContextOptions<Hrrav3GeNextPreprodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountStatus> AccountStatuses { get; set; }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<AnnouncementApplicationDetail> AnnouncementApplicationDetails { get; set; }

    public virtual DbSet<AnnouncementAttachment> AnnouncementAttachments { get; set; }

    public virtual DbSet<AnnouncementBaubleType> AnnouncementBaubleTypes { get; set; }

    public virtual DbSet<AnnouncementDecorationType> AnnouncementDecorationTypes { get; set; }

    public virtual DbSet<AnnouncementDistributionChannel> AnnouncementDistributionChannels { get; set; }

    public virtual DbSet<AnnouncementDrivingLicence> AnnouncementDrivingLicences { get; set; }

    public virtual DbSet<AnnouncementFeed> AnnouncementFeeds { get; set; }

    public virtual DbSet<AnnouncementFeedMatch> AnnouncementFeedMatches { get; set; }

    public virtual DbSet<AnnouncementFeedMatchStatus> AnnouncementFeedMatchStatuses { get; set; }

    public virtual DbSet<AnnouncementFrameType> AnnouncementFrameTypes { get; set; }

    public virtual DbSet<AnnouncementJobseekerApplication> AnnouncementJobseekerApplications { get; set; }

    public virtual DbSet<AnnouncementLanguage> AnnouncementLanguages { get; set; }

    public virtual DbSet<AnnouncementListingSection> AnnouncementListingSections { get; set; }

    public virtual DbSet<AnnouncementLocality> AnnouncementLocalities { get; set; }

    public virtual DbSet<AnnouncementLocation> AnnouncementLocations { get; set; }

    public virtual DbSet<AnnouncementLogo> AnnouncementLogos { get; set; }

    public virtual DbSet<AnnouncementMatchingJobseeker> AnnouncementMatchingJobseekers { get; set; }

    public virtual DbSet<AnnouncementMatchingJobseekerStatus> AnnouncementMatchingJobseekerStatuses { get; set; }

    public virtual DbSet<AnnouncementMatchingList> AnnouncementMatchingLists { get; set; }

    public virtual DbSet<AnnouncementMatchingListApprovalStatus> AnnouncementMatchingListApprovalStatuses { get; set; }

    public virtual DbSet<AnnouncementMatchingListGenerationStatus> AnnouncementMatchingListGenerationStatuses { get; set; }

    public virtual DbSet<AnnouncementModule> AnnouncementModules { get; set; }

    public virtual DbSet<AnnouncementOccupationCategory> AnnouncementOccupationCategories { get; set; }

    public virtual DbSet<AnnouncementPublishStatus> AnnouncementPublishStatuses { get; set; }

    public virtual DbSet<AnnouncementRenewal> AnnouncementRenewals { get; set; }

    public virtual DbSet<AnnouncementRenewalStat> AnnouncementRenewalStats { get; set; }

    public virtual DbSet<AnnouncementSite> AnnouncementSites { get; set; }

    public virtual DbSet<AnnouncementStat> AnnouncementStats { get; set; }

    public virtual DbSet<AnnouncementStatus> AnnouncementStatuses { get; set; }

    public virtual DbSet<AnnouncementType> AnnouncementTypes { get; set; }

    public virtual DbSet<AnnouncementTypeSecondaryProductConstraint> AnnouncementTypeSecondaryProductConstraints { get; set; }

    public virtual DbSet<AnnouncementWorkExperienceType> AnnouncementWorkExperienceTypes { get; set; }

    public virtual DbSet<ApplicationMethod> ApplicationMethods { get; set; }

    public virtual DbSet<ApplicationStatus> ApplicationStatuses { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<BannerClickEvent> BannerClickEvents { get; set; }

    public virtual DbSet<BannerPosition> BannerPositions { get; set; }

    public virtual DbSet<BannerStatus> BannerStatuses { get; set; }

    public virtual DbSet<BannerTarget> BannerTargets { get; set; }

    public virtual DbSet<BannerType> BannerTypes { get; set; }

    public virtual DbSet<BannerViewEvent> BannerViewEvents { get; set; }

    public virtual DbSet<BasePlacementSectionSecondaryProductConstraint> BasePlacementSectionSecondaryProductConstraints { get; set; }

    public virtual DbSet<BoothType> BoothTypes { get; set; }

    public virtual DbSet<BrandingAnnouncementTileType> BrandingAnnouncementTileTypes { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<ContentAction> ContentActions { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAgent> CustomerAgents { get; set; }

    public virtual DbSet<CustomerAgentStatus> CustomerAgentStatuses { get; set; }

    public virtual DbSet<CustomerAutomaticEmail> CustomerAutomaticEmails { get; set; }

    public virtual DbSet<CustomerAutomaticSm> CustomerAutomaticSms { get; set; }

    public virtual DbSet<CustomerBranding> CustomerBrandings { get; set; }

    public virtual DbSet<CustomerBrandingAccessToken> CustomerBrandingAccessTokens { get; set; }

    public virtual DbSet<CustomerBrandingAccessTokenStatus> CustomerBrandingAccessTokenStatuses { get; set; }

    public virtual DbSet<CustomerBrandingType> CustomerBrandingTypes { get; set; }

    public virtual DbSet<CustomerContract> CustomerContracts { get; set; }

    public virtual DbSet<CustomerContractType> CustomerContractTypes { get; set; }

    public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }

    public virtual DbSet<CustomerGroup1> CustomerGroups1 { get; set; }

    public virtual DbSet<CustomerIgnoredCustomer> CustomerIgnoredCustomers { get; set; }

    public virtual DbSet<CustomerJobseekerView> CustomerJobseekerViews { get; set; }

    public virtual DbSet<CustomerJobseekerViewEvent> CustomerJobseekerViewEvents { get; set; }

    public virtual DbSet<CustomerJobseekerViewEventSource> CustomerJobseekerViewEventSources { get; set; }

    public virtual DbSet<CustomerLocation> CustomerLocations { get; set; }

    public virtual DbSet<CustomerLogo> CustomerLogos { get; set; }

    public virtual DbSet<CustomerSavedJobseeker> CustomerSavedJobseekers { get; set; }

    public virtual DbSet<CustomerSavedJobseekerFolder> CustomerSavedJobseekerFolders { get; set; }

    public virtual DbSet<CustomerStatus> CustomerStatuses { get; set; }

    public virtual DbSet<CustomerType> CustomerTypes { get; set; }

    public virtual DbSet<CustomerTypeBasePlacementSectionConstraint> CustomerTypeBasePlacementSectionConstraints { get; set; }

    public virtual DbSet<CustomerTypeProductConstraint> CustomerTypeProductConstraints { get; set; }

    public virtual DbSet<CvBox> CvBoxes { get; set; }

    public virtual DbSet<CvBoxAccessToken> CvBoxAccessTokens { get; set; }

    public virtual DbSet<CvBoxAccessTokenStatus> CvBoxAccessTokenStatuses { get; set; }

    public virtual DbSet<CvBoxItem> CvBoxItems { get; set; }

    public virtual DbSet<CvBoxItemStatus> CvBoxItemStatuses { get; set; }

    public virtual DbSet<CvBoxPageSection> CvBoxPageSections { get; set; }

    public virtual DbSet<CvDatabaseAccessProductGroup> CvDatabaseAccessProductGroups { get; set; }

    public virtual DbSet<CvDatabaseAccessProductGroup1> CvDatabaseAccessProductGroups1 { get; set; }

    public virtual DbSet<CvDatabaseAccessToken> CvDatabaseAccessTokens { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenCvDatabaseProvider> CvDatabaseAccessTokenCvDatabaseProviders { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenEvent> CvDatabaseAccessTokenEvents { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenRequest> CvDatabaseAccessTokenRequests { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenRequestStatus> CvDatabaseAccessTokenRequestStatuses { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenStatus> CvDatabaseAccessTokenStatuses { get; set; }

    public virtual DbSet<CvDatabaseAccessTokenType> CvDatabaseAccessTokenTypes { get; set; }

    public virtual DbSet<DataType> DataTypes { get; set; }

    public virtual DbSet<DeliveryFailure> DeliveryFailures { get; set; }

    public virtual DbSet<DrivingLicence> DrivingLicences { get; set; }

    public virtual DbSet<EducationLevel> EducationLevels { get; set; }

    public virtual DbSet<EducationalInstitution> EducationalInstitutions { get; set; }

    public virtual DbSet<EducationalInstitutionType> EducationalInstitutionTypes { get; set; }

    public virtual DbSet<EducationalProgram> EducationalPrograms { get; set; }

    public virtual DbSet<EmailAttachment> EmailAttachments { get; set; }

    public virtual DbSet<EmailContent> EmailContents { get; set; }

    public virtual DbSet<EmailMessage> EmailMessages { get; set; }

    public virtual DbSet<EmailMessageRecipient> EmailMessageRecipients { get; set; }

    public virtual DbSet<EmailMessageRecipientType> EmailMessageRecipientTypes { get; set; }

    public virtual DbSet<EmailStatus> EmailStatuses { get; set; }

    public virtual DbSet<EmailType> EmailTypes { get; set; }

    public virtual DbSet<EmploymentForm> EmploymentForms { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EntityAttribute> EntityAttributes { get; set; }

    public virtual DbSet<EntityAttribute1> EntityAttributes1 { get; set; }

    public virtual DbSet<EntityAttributeBundle> EntityAttributeBundles { get; set; }

    public virtual DbSet<EntityIndexTag> EntityIndexTags { get; set; }

    public virtual DbSet<EntityNameI18n> EntityNameI18ns { get; set; }

    public virtual DbSet<EntityObject> EntityObjects { get; set; }

    public virtual DbSet<EntityType> EntityTypes { get; set; }

    public virtual DbSet<EntityType1> EntityTypes1 { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Event1> Events1 { get; set; }

    public virtual DbSet<EventParticipant> EventParticipants { get; set; }

    public virtual DbSet<EventParticipationPackage> EventParticipationPackages { get; set; }

    public virtual DbSet<EventPartnerEducationalInstitution> EventPartnerEducationalInstitutions { get; set; }

    public virtual DbSet<EventSpace> EventSpaces { get; set; }

    public virtual DbSet<EventStatus> EventStatuses { get; set; }

    public virtual DbSet<EventVisitor> EventVisitors { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<FeatureType> FeatureTypes { get; set; }

    public virtual DbSet<GeneratedDocumentTemplate> GeneratedDocumentTemplates { get; set; }

    public virtual DbSet<GeneratedDocumentTemplateContent> GeneratedDocumentTemplateContents { get; set; }

    public virtual DbSet<GeneratedDocumentType> GeneratedDocumentTypes { get; set; }

    public virtual DbSet<Handle> Handles { get; set; }

    public virtual DbSet<HandleStatus> HandleStatuses { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<IndexTag> IndexTags { get; set; }

    public virtual DbSet<IndexTagMetric> IndexTagMetrics { get; set; }

    public virtual DbSet<IndexingStatus> IndexingStatuses { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceAccountingStatus> InvoiceAccountingStatuses { get; set; }

    public virtual DbSet<InvoiceCoverage> InvoiceCoverages { get; set; }

    public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

    public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Jobseeker> Jobseekers { get; set; }

    public virtual DbSet<JobseekerAttachment> JobseekerAttachments { get; set; }

    public virtual DbSet<JobseekerDocument> JobseekerDocuments { get; set; }

    public virtual DbSet<JobseekerDocumentContentPlainText> JobseekerDocumentContentPlainTexts { get; set; }

    public virtual DbSet<JobseekerDocumentType> JobseekerDocumentTypes { get; set; }

    public virtual DbSet<JobseekerDrivingLicence> JobseekerDrivingLicences { get; set; }

    public virtual DbSet<JobseekerEducation> JobseekerEducations { get; set; }

    public virtual DbSet<JobseekerFile> JobseekerFiles { get; set; }

    public virtual DbSet<JobseekerIgnoredCustomer> JobseekerIgnoredCustomers { get; set; }

    public virtual DbSet<JobseekerLanguage> JobseekerLanguages { get; set; }

    public virtual DbSet<JobseekerLocalitySubscription> JobseekerLocalitySubscriptions { get; set; }

    public virtual DbSet<JobseekerOccupationCategorySubscription> JobseekerOccupationCategorySubscriptions { get; set; }

    public virtual DbSet<JobseekerPhoto> JobseekerPhotos { get; set; }

    public virtual DbSet<JobseekerPrivacy> JobseekerPrivacies { get; set; }

    public virtual DbSet<JobseekerProfileState> JobseekerProfileStates { get; set; }

    public virtual DbSet<JobseekerStatus> JobseekerStatuses { get; set; }

    public virtual DbSet<JobseekerSubscriptionUpdateHistory> JobseekerSubscriptionUpdateHistories { get; set; }

    public virtual DbSet<JobseekerWorkExperience> JobseekerWorkExperiences { get; set; }

    public virtual DbSet<JobseekerWorkExperienceCategory> JobseekerWorkExperienceCategories { get; set; }

    public virtual DbSet<Keyword> Keywords { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Language1> Languages1 { get; set; }

    public virtual DbSet<LanguageCharset> LanguageCharsets { get; set; }

    public virtual DbSet<LanguageProficiencyLevel> LanguageProficiencyLevels { get; set; }

    public virtual DbSet<Locality> Localities { get; set; }

    public virtual DbSet<LogoStatus> LogoStatuses { get; set; }

    public virtual DbSet<LookupStatus> LookupStatuses { get; set; }

    public virtual DbSet<MigratedRegistrantOccupationCategory> MigratedRegistrantOccupationCategories { get; set; }

    public virtual DbSet<Moderation> Moderations { get; set; }

    public virtual DbSet<ModerationContext> ModerationContexts { get; set; }

    public virtual DbSet<ModerationStatus> ModerationStatuses { get; set; }

    public virtual DbSet<MonthlyPlan> MonthlyPlans { get; set; }

    public virtual DbSet<MonthlyPlanItem> MonthlyPlanItems { get; set; }

    public virtual DbSet<MonthlyPlanProductType> MonthlyPlanProductTypes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationChannel> NotificationChannels { get; set; }

    public virtual DbSet<NotificationStatus> NotificationStatuses { get; set; }

    public virtual DbSet<NotificationSubType> NotificationSubTypes { get; set; }

    public virtual DbSet<NotificationTargetEntityType> NotificationTargetEntityTypes { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<ObjectHashCode> ObjectHashCodes { get; set; }

    public virtual DbSet<OccupationCategory> OccupationCategories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderShippingStatus> OrderShippingStatuses { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentChannel> PaymentChannels { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<PortfolioAccountManager> PortfolioAccountManagers { get; set; }

    public virtual DbSet<PortfolioCustomer> PortfolioCustomers { get; set; }

    public virtual DbSet<PostingChannel> PostingChannels { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAspect> ProductAspects { get; set; }

    public virtual DbSet<ProductAspect1> ProductAspects1 { get; set; }

    public virtual DbSet<ProductCombinationConstraint> ProductCombinationConstraints { get; set; }

    public virtual DbSet<ProductGroup> ProductGroups { get; set; }

    public virtual DbSet<ProductGroupProduct> ProductGroupProducts { get; set; }

    public virtual DbSet<ProductIncompatibilityConstraint> ProductIncompatibilityConstraints { get; set; }

    public virtual DbSet<ProductReplacementConstraint> ProductReplacementConstraints { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductTypeAvailabilityConstraint> ProductTypeAvailabilityConstraints { get; set; }

    public virtual DbSet<ProductTypeCombinationConstraint> ProductTypeCombinationConstraints { get; set; }

    public virtual DbSet<ProductUpgradeConstraint> ProductUpgradeConstraints { get; set; }

    public virtual DbSet<PromoEmailAttachment> PromoEmailAttachments { get; set; }

    public virtual DbSet<PromoEmailPortfolio> PromoEmailPortfolios { get; set; }

    public virtual DbSet<PromoEmailStatus> PromoEmailStatuses { get; set; }

    public virtual DbSet<PromoEmailTemplate> PromoEmailTemplates { get; set; }

    public virtual DbSet<ProviderWebsite> ProviderWebsites { get; set; }

    public virtual DbSet<ProviderWebsiteOccupationCategory> ProviderWebsiteOccupationCategories { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestAction> RequestActions { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<ResourceI18n> ResourceI18ns { get; set; }

    public virtual DbSet<ResourceScope> ResourceScopes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleFeature> RoleFeatures { get; set; }

    public virtual DbSet<SchemaVersion> SchemaVersions { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SettingI18n> SettingI18ns { get; set; }

    public virtual DbSet<SettingLevel> SettingLevels { get; set; }

    public virtual DbSet<SliderBanner> SliderBanners { get; set; }

    public virtual DbSet<SliderBannerStatus> SliderBannerStatuses { get; set; }

    public virtual DbSet<SmsMessage> SmsMessages { get; set; }

    public virtual DbSet<SmsStatus> SmsStatuses { get; set; }

    public virtual DbSet<SmsStopReason> SmsStopReasons { get; set; }

    public virtual DbSet<SmsStopReason1> SmsStopReasons1 { get; set; }

    public virtual DbSet<SmsTemplate> SmsTemplates { get; set; }

    public virtual DbSet<SmsTemplateContent> SmsTemplateContents { get; set; }

    public virtual DbSet<SmsType> SmsTypes { get; set; }

    public virtual DbSet<SpecialPriceOffer> SpecialPriceOffers { get; set; }

    public virtual DbSet<StaticContent> StaticContents { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<SubscriberLocalitySubscription> SubscriberLocalitySubscriptions { get; set; }

    public virtual DbSet<SubscriberOccupationCategory> SubscriberOccupationCategories { get; set; }

    public virtual DbSet<SubscriberStatus> SubscriberStatuses { get; set; }

    public virtual DbSet<SuspendedEmailAddress> SuspendedEmailAddresses { get; set; }

    public virtual DbSet<SystemConfig> SystemConfigs { get; set; }

    public virtual DbSet<TargetAudience> TargetAudiences { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TemplateContent> TemplateContents { get; set; }

    public virtual DbSet<TermTag> TermTags { get; set; }

    public virtual DbSet<TermTagRelation> TermTagRelations { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<Thread> Threads { get; set; }

    public virtual DbSet<ThreadPost> ThreadPosts { get; set; }

    public virtual DbSet<ThreadRelatedObjectType> ThreadRelatedObjectTypes { get; set; }

    public virtual DbSet<ThreadTopic> ThreadTopics { get; set; }

    public virtual DbSet<TransactionApprovalStatus> TransactionApprovalStatuses { get; set; }

    public virtual DbSet<TransactionInvoice> TransactionInvoices { get; set; }

    public virtual DbSet<TransactionRecord> TransactionRecords { get; set; }

    public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserFeature> UserFeatures { get; set; }

    public virtual DbSet<UserPreference> UserPreferences { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSmsLanguageCharset> UserSmsLanguageCharsets { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<UserStoppedEmail> UserStoppedEmails { get; set; }

    public virtual DbSet<UserStoppedSm> UserStoppedSms { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<Vatstatus> Vatstatuses { get; set; }

    public virtual DbSet<WorldLanguage> WorldLanguages { get; set; }




    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.10;Database=HRRAv3_ge-next_preprod;persist security info=True;user id=mzirakashvili;password=maR1Z!;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK_billing_Account");

            entity.ToTable("Account", "billing");

            entity.Property(e => e.AvailableAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.VatstatusId).HasColumnName("VATStatusId");
        });

        modelBuilder.Entity<AccountStatus>(entity =>
        {
            entity.HasKey(e => e.AccountStatusId).HasName("PK_billing_AccountStatus");

            entity.ToTable("AccountStatus", "billing");

            entity.Property(e => e.AccountStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PK_audit_Action");

            entity.ToTable("Action", "audit");

            entity.Property(e => e.ActionName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK_client_Admin");

            entity.ToTable("Admin", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeUserId).HasColumnName("lastChangeUserId");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneExtension)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position).HasMaxLength(100);
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PK_posting_Announcement");

            entity.ToTable("Announcement", "posting");

            entity.HasIndex(e => e.CustomerId, "IX_posting.Announcement_CustomerId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(250);
            entity.Property(e => e.CustomerName2).HasMaxLength(250);
            entity.Property(e => e.DeadlineDate).HasColumnType("datetime");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.PriorityUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.Title2).HasMaxLength(250);
        });

        modelBuilder.Entity<AnnouncementApplicationDetail>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PK_posting_Announcement_ApplicationDetail");

            entity.ToTable("Announcement_ApplicationDetail", "posting");

            entity.Property(e => e.AnnouncementId).ValueGeneratedNever();
            entity.Property(e => e.ApplicationAddress).HasMaxLength(200);
            entity.Property(e => e.ApplicationUrl).HasMaxLength(500);
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WebsiteUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnnouncementAttachment>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PK_posting_Announcement_Attachment");

            entity.ToTable("Announcement_Attachment", "posting");

            entity.Property(e => e.AnnouncementId).ValueGeneratedNever();
            entity.Property(e => e.Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<AnnouncementBaubleType>(entity =>
        {
            entity.ToTable("AnnouncementBaubleType", "posting");

            entity.Property(e => e.AnnouncementBaubleTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementDecorationType>(entity =>
        {
            entity.ToTable("AnnouncementDecorationType", "posting");

            entity.Property(e => e.AnnouncementDecorationTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementDistributionChannel>(entity =>
        {
            entity.HasKey(e => e.AnnouncementDistributionChannelId).HasName("PK_posting_Announcement_DistributionChannel");

            entity.ToTable("Announcement_DistributionChannel", "posting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeadlineDate).HasColumnType("datetime");
            entity.Property(e => e.PriorityActivationDate).HasColumnType("datetime");
            entity.Property(e => e.PriorityExpireDate).HasColumnType("datetime");
            entity.Property(e => e.PriorityUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnouncementDrivingLicence>(entity =>
        {
            entity.HasKey(e => e.AnnouncementDrivingLicenceId).HasName("PK_posting_Announcement_DrivingLicense");

            entity.ToTable("Announcement_DrivingLicence", "posting");
        });

        modelBuilder.Entity<AnnouncementFeed>(entity =>
        {
            entity.ToTable("AnnouncementFeed", "feeds");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FilterObject).HasMaxLength(2048);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.Uid).HasMaxLength(128);
        });

        modelBuilder.Entity<AnnouncementFeedMatch>(entity =>
        {
            entity.ToTable("AnnouncementFeedMatch", "feeds");
        });

        modelBuilder.Entity<AnnouncementFeedMatchStatus>(entity =>
        {
            entity.HasKey(e => e.AnnouncementFeedMatchStatusId).HasName("PK__Announce__61585BE7EF5A7716");

            entity.ToTable("AnnouncementFeedMatchStatus", "feeds");

            entity.Property(e => e.AnnouncementFeedMatchStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementFrameType>(entity =>
        {
            entity.ToTable("AnnouncementFrameType", "posting");

            entity.Property(e => e.AnnouncementFrameTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementJobseekerApplication>(entity =>
        {
            entity.HasKey(e => e.AnnouncementJobseekerApplicationId).HasName("PK_posting_AnnouncementJobseekerApplication");

            entity.ToTable("AnnouncementJobseekerApplication", "posting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LastViewDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnouncementLanguage>(entity =>
        {
            entity.HasKey(e => e.AnnouncementLanguageId).HasName("PK_posting_Announcement_Language");

            entity.ToTable("Announcement_Language", "posting");
        });

        modelBuilder.Entity<AnnouncementListingSection>(entity =>
        {
            entity.ToTable("AnnouncementListingSection", "posting");

            entity.Property(e => e.AnnouncementListingSectionId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementLocality>(entity =>
        {
            entity.HasKey(e => e.AnnouncementLocalityId).HasName("PK_posting_Announcement_Locality");

            entity.ToTable("Announcement_Locality", "posting");
        });

        modelBuilder.Entity<AnnouncementLocation>(entity =>
        {
            entity.HasKey(e => e.AnnouncementLocationId).HasName("PK_posting_Announcement_Location");

            entity.ToTable("Announcement_Location", "posting");
        });

        modelBuilder.Entity<AnnouncementLogo>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PK_posting_Announcement_Logo");

            entity.ToTable("Announcement_Logo", "posting");

            entity.Property(e => e.AnnouncementId).ValueGeneratedNever();
            entity.Property(e => e.LogoFilename).HasMaxLength(500);
            entity.Property(e => e.LogoThumbnail1Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<AnnouncementMatchingJobseeker>(entity =>
        {
            entity.HasKey(e => e.AnnouncementMatchingJobseekerId).HasName("PK__Announce__F34165ECFE14E96B");

            entity.ToTable("AnnouncementMatchingJobseeker", "matching");

            entity.Property(e => e.LastStatusUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnouncementMatchingJobseekerStatus>(entity =>
        {
            entity.ToTable("AnnouncementMatchingJobseekerStatus", "matching");

            entity.Property(e => e.AnnouncementMatchingJobseekerStatusId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementMatchingList>(entity =>
        {
            entity.ToTable("Announcement_MatchingList", "matching");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CvAccessExpireDate).HasColumnType("datetime");
            entity.Property(e => e.LastGenerationDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PlannedSendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnouncementMatchingListApprovalStatus>(entity =>
        {
            entity.ToTable("AnnouncementMatchingListApprovalStatus", "matching");

            entity.Property(e => e.AnnouncementMatchingListApprovalStatusId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementMatchingListGenerationStatus>(entity =>
        {
            entity.ToTable("AnnouncementMatchingListGenerationStatus", "matching");

            entity.Property(e => e.AnnouncementMatchingListGenerationStatusId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementModule>(entity =>
        {
            entity.HasKey(e => e.AnnouncementModuleId).HasName("PK_posting_AnnouncementModule");

            entity.ToTable("AnnouncementModule", "posting");

            entity.Property(e => e.AnnouncementModuleId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<AnnouncementOccupationCategory>(entity =>
        {
            entity.HasKey(e => e.AnnouncementOccupationCategoryId).HasName("PK_posting_Announcement_OccupationCategory");

            entity.ToTable("Announcement_OccupationCategory", "posting");
        });

        modelBuilder.Entity<AnnouncementPublishStatus>(entity =>
        {
            entity.ToTable("AnnouncementPublishStatus", "posting");

            entity.Property(e => e.AnnouncementPublishStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnouncementRenewal>(entity =>
        {
            entity.ToTable("AnnouncementRenewal", "posting");

            entity.Property(e => e.ActualRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduledRenewalDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnouncementRenewalStat>(entity =>
        {
            entity.ToTable("AnnouncementRenewal_Stat", "posting");
        });

        modelBuilder.Entity<AnnouncementSite>(entity =>
        {
            entity.HasKey(e => e.AnnouncementSiteId).HasName("PK_posting_AnnouncementSite");

            entity.ToTable("AnnouncementSite", "posting");

            entity.Property(e => e.AnnouncementSiteId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnnouncementStat>(entity =>
        {
            entity.ToTable("Announcement_Stat", "posting");

            entity.Property(e => e.AnnouncementStatId).HasColumnName("Announcement_StatId");
        });

        modelBuilder.Entity<AnnouncementStatus>(entity =>
        {
            entity.HasKey(e => e.AnnouncementStatusId).HasName("PK_posting_AnnouncementStatus");

            entity.ToTable("AnnouncementStatus", "posting");

            entity.Property(e => e.AnnouncementStatusId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<AnnouncementType>(entity =>
        {
            entity.HasKey(e => e.AnnouncementTypeId).HasName("PK_posting_AnnouncementType");

            entity.ToTable("AnnouncementType", "posting");

            entity.Property(e => e.AnnouncementTypeId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AnnouncementTypeSecondaryProductConstraint>(entity =>
        {
            entity.ToTable("AnnouncementTypeSecondaryProductConstraint", "constraints");
        });

        modelBuilder.Entity<AnnouncementWorkExperienceType>(entity =>
        {
            entity.ToTable("AnnouncementWorkExperienceType", "posting");

            entity.Property(e => e.AnnouncementWorkExperienceTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicationMethod>(entity =>
        {
            entity.HasKey(e => e.ApplicationMethodId).HasName("PK_posting_ApplicationMethod");

            entity.ToTable("ApplicationMethod", "posting");

            entity.Property(e => e.ApplicationMethodId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ApplicationStatus>(entity =>
        {
            entity.HasKey(e => e.ApplicationStatusId).HasName("PK_posting_AnnouncementApplicationStatus");

            entity.ToTable("ApplicationStatus", "posting");

            entity.Property(e => e.ApplicationStatusId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK_billing_Bank");

            entity.ToTable("Bank", "billing");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.ToTable("Banner", "ads");

            entity.Property(e => e.ActivationDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeactivationDate).HasColumnType("datetime");
            entity.Property(e => e.ImageFileName).HasMaxLength(500);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Link).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BannerClickEvent>(entity =>
        {
            entity.ToTable("BannerClickEvent", "ads");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BannerPosition>(entity =>
        {
            entity.ToTable("BannerPosition", "ads");

            entity.Property(e => e.BannerPositionId).ValueGeneratedNever();
            entity.Property(e => e.DesktopHeight).HasMaxLength(50);
            entity.Property(e => e.DesktopWidth).HasMaxLength(50);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ResponsiveHeight).HasMaxLength(50);
            entity.Property(e => e.ResponsiveWidth).HasMaxLength(50);
        });

        modelBuilder.Entity<BannerStatus>(entity =>
        {
            entity.ToTable("BannerStatus", "ads");

            entity.Property(e => e.BannerStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BannerTarget>(entity =>
        {
            entity.ToTable("BannerTarget", "ads");

            entity.Property(e => e.BannerTargetId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BannerType>(entity =>
        {
            entity.ToTable("BannerType", "ads");

            entity.Property(e => e.BannerTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BannerViewEvent>(entity =>
        {
            entity.ToTable("BannerViewEvent", "ads");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BasePlacementSectionSecondaryProductConstraint>(entity =>
        {
            entity.ToTable("BasePlacementSectionSecondaryProductConstraint", "constraints");
        });

        modelBuilder.Entity<BoothType>(entity =>
        {
            entity.ToTable("BoothType", "posting");

            entity.Property(e => e.BoothTypeId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BrandingAnnouncementTileType>(entity =>
        {
            entity.ToTable("BrandingAnnouncementTileType", "client");

            entity.Property(e => e.BrandingAnnouncementTileTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("PK_mod_Content");

            entity.ToTable("Content", "mod");

            entity.HasIndex(e => e.EntityAttributeId, "IX_Content_EntityAttributeId");

            entity.HasIndex(e => e.RequestId, "IX_Content_RequestId");

            entity.HasIndex(e => e.IsProcessed, "IX_mod_Content_IsProcessed_inc_RequestId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentValueDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.NewValueDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ContentAction>(entity =>
        {
            entity.HasKey(e => e.ContentActionId).HasName("PK_mod_ContentAction");

            entity.ToTable("ContentAction", "mod");

            entity.Property(e => e.ContentActionId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK_common_Country");

            entity.ToTable("Country", "common");

            entity.Property(e => e.Alpha2Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Alpha3Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_client_Customer");

            entity.ToTable("Customer", "client");

            entity.HasIndex(e => e.IdNumber, "Customer_IdNumber_Unique").IsUnique();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IdNumber).HasMaxLength(20);
            entity.Property(e => e.InactiveDate).HasColumnType("datetime");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LastAutomaticEmailSendDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LegalAddress).HasMaxLength(250);
            entity.Property(e => e.LegalAddress2).HasMaxLength(250);
            entity.Property(e => e.LegalName).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Name2).HasMaxLength(250);
            entity.Property(e => e.NextDebtRemindDate).HasColumnType("datetime");
            entity.Property(e => e.Postcode).HasMaxLength(25);
            entity.Property(e => e.PublicEmail).HasMaxLength(250);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VerificationExpireDate).HasColumnType("datetime");
            entity.Property(e => e.VideoUrl).HasMaxLength(200);
            entity.Property(e => e.Website).HasMaxLength(250);
        });

        modelBuilder.Entity<CustomerAgent>(entity =>
        {
            entity.HasKey(e => e.CustomerAgentId).HasName("PK_client_CustomerAgent");

            entity.ToTable("CustomerAgent", "client");

            entity.HasIndex(e => e.UserId, "IX_client_CustomerAgent_UserId").IsUnique();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.MobilePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhoneNumber2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone1Extension)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position).HasMaxLength(200);
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerAgentStatus>(entity =>
        {
            entity.HasKey(e => e.CustomerAgentStatusId).HasName("PK_client_CustomerAgentStatus");

            entity.ToTable("CustomerAgentStatus", "client");

            entity.Property(e => e.CustomerAgentStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerAutomaticEmail>(entity =>
        {
            entity.ToTable("CustomerAutomaticEmail", "client");

            entity.Property(e => e.SendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerAutomaticSm>(entity =>
        {
            entity.HasKey(e => e.CustomerAutomaticSmsId);

            entity.ToTable("CustomerAutomaticSms", "client");

            entity.Property(e => e.ContentInfo).HasMaxLength(4000);
            entity.Property(e => e.SendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerBranding>(entity =>
        {
            entity.ToTable("CustomerBranding", "client");

            entity.Property(e => e.AnnouncementDetailsBgColor).HasMaxLength(50);
            entity.Property(e => e.AnnouncementDetailsDesktopBgImage).HasMaxLength(500);
            entity.Property(e => e.AnnouncementDetailsMobileBgImage).HasMaxLength(500);
            entity.Property(e => e.AnnouncementTileColor).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCoverImage).HasMaxLength(500);
            entity.Property(e => e.CustomerDetailsBgColor).HasMaxLength(50);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerBrandingAccessToken>(entity =>
        {
            entity.ToTable("CustomerBrandingAccessToken", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            entity.Property(e => e.TokenExpireDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerBrandingAccessTokenStatus>(entity =>
        {
            entity.ToTable("CustomerBrandingAccessTokenStatus", "client");

            entity.Property(e => e.CustomerBrandingAccessTokenStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerBrandingType>(entity =>
        {
            entity.ToTable("CustomerBrandingType", "client");

            entity.Property(e => e.CustomerBrandingTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerContract>(entity =>
        {
            entity.ToTable("CustomerContract", "client");

            entity.Property(e => e.CreateDate).HasColumnType("date");
            entity.Property(e => e.ExpireDate).HasColumnType("date");
            entity.Property(e => e.FileName).HasMaxLength(500);
        });

        modelBuilder.Entity<CustomerContractType>(entity =>
        {
            entity.ToTable("CustomerContractType", "client");

            entity.Property(e => e.CustomerContractTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerGroup>(entity =>
        {
            entity.ToTable("Customer_Group", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerGroup1>(entity =>
        {
            entity.HasKey(e => e.CustomerGroupId);

            entity.ToTable("CustomerGroup", "client");

            entity.Property(e => e.CustomerGroupId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerIgnoredCustomer>(entity =>
        {
            entity.ToTable("Customer_IgnoredCustomer", "feeds");
        });

        modelBuilder.Entity<CustomerJobseekerView>(entity =>
        {
            entity.HasKey(e => e.CustomerJobseekerViewId).HasName("PK_client_CustomerJobseekerView");

            entity.ToTable("CustomerJobseekerView", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastViewDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerJobseekerViewEvent>(entity =>
        {
            entity.HasKey(e => e.JobseekerViewEventId);

            entity.ToTable("CustomerJobseekerViewEvent", "client");

            entity.Property(e => e.EventDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerJobseekerViewEventSource>(entity =>
        {
            entity.ToTable("CustomerJobseekerViewEventSource", "client");

            entity.Property(e => e.CustomerJobseekerViewEventSourceId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerLocation>(entity =>
        {
            entity.HasKey(e => e.CustomerLocationId).HasName("PK_client_CustomerLocation");

            entity.ToTable("CustomerLocation", "client");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Latitude).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Longitude).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        modelBuilder.Entity<CustomerLogo>(entity =>
        {
            entity.HasKey(e => e.CustomerLogoId).HasName("PK_client_CustomerLogo");

            entity.ToTable("CustomerLogo", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LogoFilename).HasMaxLength(500);
            entity.Property(e => e.LogoThumbnail1Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<CustomerSavedJobseeker>(entity =>
        {
            entity.HasKey(e => e.CustomerSavedJobseekerId).HasName("PK_client_CustomerSavedJobseeker");

            entity.ToTable("CustomerSavedJobseeker", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerSavedJobseekerFolder>(entity =>
        {
            entity.HasKey(e => e.CustomerSavedJobseekerFolderId).HasName("PK_client_CustomerSavedJobseekerFolder");

            entity.ToTable("CustomerSavedJobseekerFolder", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FolderName).HasMaxLength(500);
        });

        modelBuilder.Entity<CustomerStatus>(entity =>
        {
            entity.HasKey(e => e.CustomerStatusId).HasName("PK_client_CustomerStatus");

            entity.ToTable("CustomerStatus", "client");

            entity.Property(e => e.CustomerStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerType>(entity =>
        {
            entity.HasKey(e => e.CustomerTypeId).HasName("PK_client_CustomerType");

            entity.ToTable("CustomerType", "client");

            entity.Property(e => e.CustomerTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerTypeBasePlacementSectionConstraint>(entity =>
        {
            entity.ToTable("CustomerTypeBasePlacementSectionConstraint", "constraints");
        });

        modelBuilder.Entity<CustomerTypeProductConstraint>(entity =>
        {
            entity.ToTable("CustomerTypeProductConstraint", "constraints");
        });

        modelBuilder.Entity<CvBox>(entity =>
        {
            entity.ToTable("CvBox", "client");
        });

        modelBuilder.Entity<CvBoxAccessToken>(entity =>
        {
            entity.ToTable("CvBoxAccessToken", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CvSendExpireDate).HasColumnType("datetime");
            entity.Property(e => e.CvViewExpireDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            entity.Property(e => e.TokenExpireDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvBoxAccessTokenStatus>(entity =>
        {
            entity.ToTable("CvBoxAccessTokenStatus", "client");

            entity.Property(e => e.CvBoxAccessTokenStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvBoxItem>(entity =>
        {
            entity.ToTable("CvBoxItem", "client");

            entity.Property(e => e.SendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvBoxItemStatus>(entity =>
        {
            entity.ToTable("CvBoxItemStatus", "client");

            entity.Property(e => e.CvBoxItemStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvBoxPageSection>(entity =>
        {
            entity.ToTable("CvBoxPageSection", "client");

            entity.Property(e => e.CvBoxPageSectionId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvDatabaseAccessProductGroup>(entity =>
        {
            entity.ToTable("CvDatabaseAccessProductGroup", "client");

            entity.Property(e => e.CvDatabaseAccessProductGroupId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvDatabaseAccessProductGroup1>(entity =>
        {
            entity.HasKey(e => e.CvDatabaseAccessProductGroupId).HasName("PK__CvDataba__AAA55836271D75B9");

            entity.ToTable("CvDatabaseAccessProductGroup", "store");

            entity.Property(e => e.CvDatabaseAccessProductGroupId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvDatabaseAccessToken>(entity =>
        {
            entity.ToTable("CvDatabaseAccessToken", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.FullAccessExpireDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvDatabaseAccessTokenCvDatabaseProvider>(entity =>
        {
            entity.ToTable("CvDatabaseAccessToken_CvDatabaseProvider", "client");
        });

        modelBuilder.Entity<CvDatabaseAccessTokenEvent>(entity =>
        {
            entity.ToTable("CvDatabaseAccessToken_Event", "client");
        });

        modelBuilder.Entity<CvDatabaseAccessTokenRequest>(entity =>
        {
            entity.ToTable("CvDatabaseAccessTokenRequest", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvDatabaseAccessTokenRequestStatus>(entity =>
        {
            entity.ToTable("CvDatabaseAccessTokenRequestStatus", "client");

            entity.Property(e => e.CvDatabaseAccessTokenRequestStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvDatabaseAccessTokenStatus>(entity =>
        {
            entity.ToTable("CvDatabaseAccessTokenStatus", "client");

            entity.Property(e => e.CvDatabaseAccessTokenStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CvDatabaseAccessTokenType>(entity =>
        {
            entity.ToTable("CvDatabaseAccessTokenType", "client");

            entity.Property(e => e.CvDatabaseAccessTokenTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DataType>(entity =>
        {
            entity.HasKey(e => e.DataTypeId).HasName("PK_meta_DataType");

            entity.ToTable("DataType", "meta");

            entity.Property(e => e.DataTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DeliveryFailure>(entity =>
        {
            entity.HasKey(e => e.DeliveryFailureId).HasName("PK_messaging_DeliveryFailure");

            entity.ToTable("DeliveryFailure", "messaging");

            entity.Property(e => e.DeliveryFailureId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DrivingLicence>(entity =>
        {
            entity.HasKey(e => e.DrivingLicenceId).HasName("PK_common_DrivingLicence");

            entity.ToTable("DrivingLicence", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EducationLevel>(entity =>
        {
            entity.HasKey(e => e.EducationLevelId).HasName("PK_common_EducationLevel");

            entity.ToTable("EducationLevel", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<EducationalInstitution>(entity =>
        {
            entity.HasKey(e => e.EducationalInstitutionId).HasName("PK_EducationlInstitution");

            entity.ToTable("EducationalInstitution", "common");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LogoFilename).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameLatin).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EducationalInstitutionType>(entity =>
        {
            entity.HasKey(e => e.EducationalInstitutionTypeId).HasName("PK_common_EducatioalInstitutionType");

            entity.ToTable("EducationalInstitutionType", "common");

            entity.Property(e => e.EducationalInstitutionTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<EducationalProgram>(entity =>
        {
            entity.ToTable("EducationalProgram", "common");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EducationalInstitutionCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(2000);
            entity.Property(e => e.NameLatin).HasMaxLength(2000);
            entity.Property(e => e.NameShort).HasMaxLength(2000);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailAttachment>(entity =>
        {
            entity.ToTable("EmailAttachment", "messaging");

            entity.HasIndex(e => e.EmailMessageId, "IX_EmailAttachment_EmailMessageId");

            entity.Property(e => e.AttachmentFileId).HasMaxLength(500);
            entity.Property(e => e.AttachmentName).HasMaxLength(256);
        });

        modelBuilder.Entity<EmailContent>(entity =>
        {
            entity.HasKey(e => e.EmailContentId).HasName("PK_messaging_EmailContent");

            entity.ToTable("EmailContent", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailMessage>(entity =>
        {
            entity.HasKey(e => e.EmailMessageId).HasName("PK_messaging_EmailMessage");

            entity.ToTable("EmailMessage", "messaging");

            entity.HasIndex(e => e.EmailStatusId, "IX_EmailMessage_EmailStatusId");

            entity.HasIndex(e => new { e.EmailStatusId, e.IsDeleted, e.PlannedSendDate }, "IX_EmailMessage_EmailStatusId_IsDeleted_PlannedSendDate");

            entity.Property(e => e.Bccaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BCCAddress");
            entity.Property(e => e.Ccaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CCAddress");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FromTitle).HasMaxLength(50);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.PlannedSendDate).HasColumnType("datetime");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.Tags).HasMaxLength(128);
            entity.Property(e => e.TemplatKeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmailMessageRecipient>(entity =>
        {
            entity.ToTable("EmailMessageRecipient", "messaging");

            entity.HasIndex(e => e.EmailMessageId, "IX_EmailMessageRecipient_EmailMessageId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmailMessageRecipientType>(entity =>
        {
            entity.HasKey(e => e.EmailMessageRecipientTypeId).HasName("PK_EmailMessageRecipientTypeId");

            entity.ToTable("EmailMessageRecipientType", "messaging");

            entity.Property(e => e.EmailMessageRecipientTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(16);
        });

        modelBuilder.Entity<EmailStatus>(entity =>
        {
            entity.HasKey(e => e.EmailStatusId).HasName("PK_messaging_EmailStatus");

            entity.ToTable("EmailStatus", "messaging");

            entity.Property(e => e.EmailStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EmailType>(entity =>
        {
            entity.ToTable("EmailType", "messaging");

            entity.Property(e => e.EmailTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EmploymentForm>(entity =>
        {
            entity.HasKey(e => e.EmploymentFormId).HasName("PK_common_EmploymentForm");

            entity.ToTable("EmploymentForm", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.HasKey(e => new { e.EntityTypeId, e.EntityId }).HasName("PK_indexing_Entity");

            entity.ToTable("Entity", "indexing");

            entity.HasIndex(e => e.EntityTypeId, "IX_indexing_Entity_EntityTypeId");

            entity.Property(e => e.InsertDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EntityAttribute>(entity =>
        {
            entity.HasKey(e => e.EntityAttributeId).HasName("PK_indexing_EntityAttribute");

            entity.ToTable("EntityAttribute", "indexing");

            entity.Property(e => e.EntityAttributeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<EntityAttribute1>(entity =>
        {
            entity.HasKey(e => e.EntityAttributeId).HasName("PK_mod_EntityAttribute");

            entity.ToTable("EntityAttribute", "mod");

            entity.Property(e => e.EntityAttributeId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ValueEntityObjectId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntityAttributeBundle>(entity =>
        {
            entity.HasKey(e => e.EntityAttributeBundleId).HasName("PK_mod_EntityAttributeBundle");

            entity.ToTable("EntityAttributeBundle", "mod");

            entity.Property(e => e.EntityAttributeBundleId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityIndexTag>(entity =>
        {
            entity.HasKey(e => e.EntityIndexTagId).HasName("PK_indexing_EntityIndexTag");

            entity.ToTable("EntityIndexTag", "indexing");

            entity.HasIndex(e => e.EntityAttributeId, "IX_EntityIndexTag_EntityAttributeId");

            entity.HasIndex(e => e.EntityId, "IX_EntityIndexTag_EntityId");

            entity.HasIndex(e => e.EntityTypeId, "IX_EntityIndexTag_EntityTypeId");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityAttributeId }, "IX_EntityIndexTag_EntityTypeId_EntityAttributeId");

            entity.HasIndex(e => e.IndexTagId, "IX_EntityIndexTag_IndexTagId");

            entity.Property(e => e.EntityAttributeId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityNameI18n>(entity =>
        {
            entity.HasKey(e => e.I18nId).HasName("PK_common_EntityNameI18n");

            entity.ToTable("EntityNameI18n", "common");

            entity.HasIndex(e => new { e.EntityObjectId, e.EntityId, e.LanguageId }, "IX_common_EntityNameI18n_EntityObjectId_EntityId_LanguageId_unique").IsUnique();

            entity.Property(e => e.EntityObjectId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntityObjectName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntityObject>(entity =>
        {
            entity.HasKey(e => e.EntityObjectId).HasName("PK_meta_EntityObject");

            entity.ToTable("EntityObject", "meta");

            entity.Property(e => e.EntityObjectId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ObjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityType>(entity =>
        {
            entity.HasKey(e => e.EntityTypeId).HasName("PK_indexing_EntityType");

            entity.ToTable("EntityType", "indexing");

            entity.Property(e => e.EntityTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EntityType1>(entity =>
        {
            entity.HasKey(e => e.EntityTypeId).HasName("PK_mod_EntityType");

            entity.ToTable("EntityType", "mod");

            entity.Property(e => e.EntityTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_mod_Event");

            entity.ToTable("Event", "mod");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Event1>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.ToTable("Event", "posting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EventVenue).HasMaxLength(100);
            entity.Property(e => e.EventVenueLatitude).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.EventVenueLongtitude).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OnlineEventStartDate).HasColumnType("datetime");
            entity.Property(e => e.OnlinelEventEndDate).HasColumnType("datetime");
            entity.Property(e => e.OnsiteEventEndDate).HasColumnType("datetime");
            entity.Property(e => e.OnsiteEventStartDate).HasColumnType("datetime");
            entity.Property(e => e.UrlShortName).HasMaxLength(50);
        });

        modelBuilder.Entity<EventParticipant>(entity =>
        {
            entity.ToTable("EventParticipant", "posting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventParticipationPackage>(entity =>
        {
            entity.ToTable("EventParticipationPackage", "posting");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EventPartnerEducationalInstitution>(entity =>
        {
            entity.ToTable("EventPartnerEducationalInstitution", "posting");
        });

        modelBuilder.Entity<EventSpace>(entity =>
        {
            entity.HasKey(e => e.EventSpaceId).HasName("PK_mod_EventSpace");

            entity.ToTable("EventSpace", "mod");

            entity.Property(e => e.EventSpaceId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventStatus>(entity =>
        {
            entity.ToTable("EventStatus", "posting");

            entity.Property(e => e.EventStatusId).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EventVisitor>(entity =>
        {
            entity.ToTable("EventVisitor", "posting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasKey(e => e.FeatureId).HasName("PK_auth_Feature");

            entity.ToTable("Feature", "auth");

            entity.Property(e => e.FeatureId).ValueGeneratedNever();
            entity.Property(e => e.KeyName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<FeatureType>(entity =>
        {
            entity.HasKey(e => e.FeatureTypeId).HasName("PK_auth_FeatureType");

            entity.ToTable("FeatureType", "auth");

            entity.Property(e => e.FeatureTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneratedDocumentTemplate>(entity =>
        {
            entity.ToTable("GeneratedDocumentTemplate", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<GeneratedDocumentTemplateContent>(entity =>
        {
            entity.ToTable("GeneratedDocumentTemplateContent", "client");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GeneratedDocumentType>(entity =>
        {
            entity.ToTable("GeneratedDocumentType", "client");

            entity.Property(e => e.GeneratedDocumentTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Handle>(entity =>
        {
            entity.HasKey(e => e.HandleId).HasName("PK_mod_Handle");

            entity.ToTable("Handle", "mod");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "IX_Handle_EntityTypeId_EntityId");

            entity.HasIndex(e => e.HeadHandleId, "IX_Handle_HeadHandleId");

            entity.HasIndex(e => e.ParentHandleId, "IX_Handle_ParentHandleId");

            entity.Property(e => e.BindDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LockDate).HasColumnType("datetime");
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HandleStatus>(entity =>
        {
            entity.HasKey(e => e.HandleStatusId).HasName("PK_mod_HandleStatus");

            entity.ToTable("HandleStatus", "mod");

            entity.Property(e => e.HandleStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.ToTable("Holiday", "common");

            entity.Property(e => e.Day).HasColumnName("day");
        });

        modelBuilder.Entity<IndexTag>(entity =>
        {
            entity.HasKey(e => e.IndexTagId).HasName("PK_indexing_IndexTag");

            entity.ToTable("IndexTag", "indexing");

            entity.HasIndex(e => e.HashCode, "IX_IndexTag");

            entity.HasIndex(e => e.ValueBool, "IX_IndexTag_ValueBool");

            entity.HasIndex(e => e.ValueDate, "IX_IndexTag_ValueDate");

            entity.HasIndex(e => e.ValueInteger, "IX_IndexTag_ValueInteger");

            entity.HasIndex(e => e.ValueString, "IX_IndexTag_ValueString");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValueDate).HasColumnType("date");
            entity.Property(e => e.ValueString)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndexTagMetric>(entity =>
        {
            entity.HasKey(e => e.IndexTagMetricId).HasName("PK_indexing_IndexTag_Metric");

            entity.ToTable("IndexTag_Metric", "indexing");

            entity.HasIndex(e => e.IndexTagId, "IX_IndexTagMetric_IndexTagId");

            entity.HasIndex(e => e.IndexTagId, "IX_IndexTagMetric_IndexTagId_inc_Metric_TagTrait");

            entity.HasIndex(e => e.TagTrait, "IX_IndexTagMetric_TagTrait");

            entity.HasIndex(e => e.TagTrait, "IX_indexing_IndexTagMetric_TagTrait_inc_IndexTagId_Metric");

            entity.Property(e => e.TagTrait)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndexingStatus>(entity =>
        {
            entity.HasKey(e => e.IndexingStatusId).HasName("PK__Indexing__E0F5E788908546FC");

            entity.ToTable("IndexingStatus", "indexing");

            entity.Property(e => e.IndexingStatusId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Industry>(entity =>
        {
            entity.HasKey(e => e.IndustryId).HasName("PK_common_Industry");

            entity.ToTable("Industry", "common");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice", "billing");

            entity.Property(e => e.ActivationDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceFileId).HasMaxLength(500);
            entity.Property(e => e.InvoiceFileSendDate).HasColumnType("datetime");
            entity.Property(e => e.LastStatusChangeDate).HasColumnType("datetime");
            entity.Property(e => e.PayOffDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Vatamount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VATAmount");
        });

        modelBuilder.Entity<InvoiceAccountingStatus>(entity =>
        {
            entity.ToTable("InvoiceAccountingStatus", "billing");

            entity.Property(e => e.InvoiceAccountingStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoiceCoverage>(entity =>
        {
            entity.ToTable("InvoiceCoverage", "billing");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.LastAmountEditDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InvoiceStatus>(entity =>
        {
            entity.HasKey(e => e.InvoiceStatusId).HasName("PK_billing_InvoiceStatus");

            entity.ToTable("InvoiceStatus", "billing");

            entity.Property(e => e.InvoiceStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoiceType>(entity =>
        {
            entity.HasKey(e => e.InvoiceTypeId).HasName("PK_billing_InvoiceType");

            entity.ToTable("InvoiceType", "billing");

            entity.Property(e => e.InvoiceTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_store_Item");

            entity.ToTable("Item", "store");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK_system_Job");

            entity.ToTable("Job", "system");

            entity.HasIndex(e => e.Status, "IX_Job_Status");

            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AdditionalInfo).HasMaxLength(4000);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Jobseeker>(entity =>
        {
            entity.HasKey(e => e.JobseekerId).HasName("PK_client_Jobseeker");

            entity.ToTable("Jobseeker", "client");

            entity.HasIndex(e => e.IndexingStatusId, "IX_Jobseeker_IndexingStatusId");

            entity.HasIndex(e => e.UserId, "IX_Jobseeker_UserId").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ExportedCvFileId).HasMaxLength(500);
            entity.Property(e => e.InactiveDate).HasColumnType("datetime");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LastFlagUnflagInternalEmployeeDate).HasColumnType("datetime");
            entity.Property(e => e.LastProfileStateCheckDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfileFillDate).HasColumnType("datetime");
            entity.Property(e => e.ReactivateDate).HasColumnType("datetime");
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<JobseekerAttachment>(entity =>
        {
            entity.HasKey(e => e.JobseekerAttachmentId).HasName("PK_client_Jobseeker_Attachment");

            entity.ToTable("Jobseeker_Attachment", "client");
        });

        modelBuilder.Entity<JobseekerDocument>(entity =>
        {
            entity.HasKey(e => e.JobseekerDocumentId).HasName("PK_client_Jobseeker_Document");

            entity.ToTable("Jobseeker_Document", "client");

            entity.Property(e => e.ContentType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Filename).HasMaxLength(500);
            entity.Property(e => e.Label).HasMaxLength(500);
        });

        modelBuilder.Entity<JobseekerDocumentContentPlainText>(entity =>
        {
            entity.ToTable("JobseekerDocumentContentPlainText", "client");

            entity.Property(e => e.Filename).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JobseekerDocumentType>(entity =>
        {
            entity.HasKey(e => e.JobseekerDocumentTypeId).HasName("PK_client_JobseekerDocumentType");

            entity.ToTable("JobseekerDocumentType", "client");

            entity.Property(e => e.JobseekerDocumentTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<JobseekerDrivingLicence>(entity =>
        {
            entity.HasKey(e => e.JobseekerDrivingLicenceId).HasName("PK_client_Jobseeker_DrivingLicence");

            entity.ToTable("Jobseeker_DrivingLicence", "client");

            entity.HasIndex(e => e.DrivingLicenceId, "IX_JobseekerDrivingLicense_DrivingLicenseId_inc_JobseekerId");

            entity.HasIndex(e => new { e.JobseekerId, e.DrivingLicenceId }, "IX_JobseekerDrivingLicense_JobseekerId_DrivingLicenseId");
        });

        modelBuilder.Entity<JobseekerEducation>(entity =>
        {
            entity.HasKey(e => e.JobseekerEducationId).HasName("PK_client_Jobseeker_Education");

            entity.ToTable("Jobseeker_Education", "client");

            entity.HasIndex(e => e.EducationLevelId, "IX_JobseekerEducation_EducationLevelId_inc_JobseekerId");

            entity.HasIndex(e => new { e.JobseekerId, e.EducationLevelId }, "IX_JobseekerEducation_JobseekerId_EducationLevelId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EducationalProgramName).HasMaxLength(1000);
            entity.Property(e => e.Institution).HasMaxLength(300);
            entity.Property(e => e.Specialization).HasMaxLength(300);
        });

        modelBuilder.Entity<JobseekerFile>(entity =>
        {
            entity.HasKey(e => e.JobseekerFileId).HasName("PK_client_Jobseeker_File");

            entity.ToTable("Jobseeker_File", "client");

            entity.Property(e => e.ContentType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<JobseekerIgnoredCustomer>(entity =>
        {
            entity.HasKey(e => e.JobseekerIgnoredCustomerId).HasName("PK_client_Jobseeker_IgnoredCustomer");

            entity.ToTable("Jobseeker_IgnoredCustomer", "client");
        });

        modelBuilder.Entity<JobseekerLanguage>(entity =>
        {
            entity.HasKey(e => e.JobseekerLanguageId).HasName("PK_client_Jobseeker_Language");

            entity.ToTable("Jobseeker_Language", "client");

            entity.HasIndex(e => new { e.JobseekerId, e.WorldLanguageId }, "IX_JobseekerLanguage_JobseekerId_WorldLanguageId");

            entity.HasIndex(e => e.WorldLanguageId, "IX_JobseekerLanguage_WorldLanguageId_inc_JobseekerId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JobseekerLocalitySubscription>(entity =>
        {
            entity.ToTable("Jobseeker_LocalitySubscription", "client");
        });

        modelBuilder.Entity<JobseekerOccupationCategorySubscription>(entity =>
        {
            entity.HasKey(e => e.JobseekerOccupationCategorySubscriptionId).HasName("PK_client_Jobseeker_OccupationCategorySubscription");

            entity.ToTable("Jobseeker_OccupationCategorySubscription", "client");
        });

        modelBuilder.Entity<JobseekerPhoto>(entity =>
        {
            entity.HasKey(e => e.JobseekerId).HasName("PK_client_jobseeker_Photo");

            entity.ToTable("Jobseeker_Photo", "client");

            entity.Property(e => e.JobseekerId).ValueGeneratedNever();
            entity.Property(e => e.Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<JobseekerPrivacy>(entity =>
        {
            entity.HasKey(e => e.JobseekerPrivacyId).HasName("PK_client_JobseekerPrivacy");

            entity.ToTable("JobseekerPrivacy", "client");

            entity.Property(e => e.JobseekerPrivacyId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<JobseekerProfileState>(entity =>
        {
            entity.HasKey(e => e.JobseekerProfileStateId).HasName("PK_client_JobseekerProfileState");

            entity.ToTable("JobseekerProfileState", "client");

            entity.Property(e => e.JobseekerProfileStateId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<JobseekerStatus>(entity =>
        {
            entity.HasKey(e => e.JobseekerStatusId).HasName("PK_client_JobseekerStatus");

            entity.ToTable("JobseekerStatus", "client");

            entity.Property(e => e.JobseekerStatusId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<JobseekerSubscriptionUpdateHistory>(entity =>
        {
            entity.ToTable("JobseekerSubscriptionUpdateHistory", "client");

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JobseekerWorkExperience>(entity =>
        {
            entity.HasKey(e => e.JobseekerWorkExperienceId).HasName("PK_client_Jobseeker_WorkExperience");

            entity.ToTable("Jobseeker_WorkExperience", "client");

            entity.HasIndex(e => e.JobseekerId, "IX_JobseekerWorkExperience_JobseekerId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Employer).HasMaxLength(200);
            entity.Property(e => e.PositionTitle).HasMaxLength(200);
        });

        modelBuilder.Entity<JobseekerWorkExperienceCategory>(entity =>
        {
            entity.HasKey(e => e.JobseekerWorkExperienceCategoryId).HasName("PK_client_JobseekerWorkExperience_Category");

            entity.ToTable("JobseekerWorkExperience_Category", "client");

            entity.HasIndex(e => e.OccupationCategoryId, "IX_jobseekerWorkExperienceCategory_OccupationCategoryId_inc_JobseekerWorkExperienceId");
        });

        modelBuilder.Entity<Keyword>(entity =>
        {
            entity.HasKey(e => e.KeywordId).HasName("PK_indexing_Keyword");

            entity.ToTable("Keyword", "indexing");

            entity.Property(e => e.KeywordText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK_common_Language");

            entity.ToTable("Language", "common");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Language1>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK_ux_Language");

            entity.ToTable("Language", "ux");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CultureName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.IsUi).HasColumnName("IsUI");
            entity.Property(e => e.NativeName).HasMaxLength(50);
            entity.Property(e => e.ShortNativeName).HasMaxLength(50);
        });

        modelBuilder.Entity<LanguageCharset>(entity =>
        {
            entity.ToTable("LanguageCharset", "messaging");

            entity.Property(e => e.LanguageCharsetId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<LanguageProficiencyLevel>(entity =>
        {
            entity.HasKey(e => e.LanguageProficiencyLevelId).HasName("PK_common_LanguageProficiencyLevel");

            entity.ToTable("LanguageProficiencyLevel", "common");

            entity.Property(e => e.LanguageProficiencyLevelId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Locality>(entity =>
        {
            entity.HasKey(e => e.LocalityId).HasName("PK_common_Locality");

            entity.ToTable("Locality", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<LogoStatus>(entity =>
        {
            entity.HasKey(e => e.LogoStatusId).HasName("PK_common_LogoStatus");

            entity.ToTable("LogoStatus", "common");

            entity.Property(e => e.LogoStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<LookupStatus>(entity =>
        {
            entity.HasKey(e => e.LookupStatusId).HasName("PK_common_LookupStatus");

            entity.ToTable("LookupStatus", "common");

            entity.Property(e => e.LookupStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<MigratedRegistrantOccupationCategory>(entity =>
        {
            entity.HasKey(e => e.MigratedRegistrantOccupationCategoryId).HasName("PK_MigratedRegistrant_OccupationCategory_1");

            entity.ToTable("MigratedRegistrant_OccupationCategory", "client");

            entity.HasIndex(e => new { e.JobseekerId, e.OccupationCategoryId }, "IX_MigratedRegistrantOccupationCategory_JobseekerId_OccupationCategoryId");

            entity.Property(e => e.MigratedRegistrantOccupationCategoryId).HasColumnName("MigratedRegistrant_OccupationCategoryId");
        });

        modelBuilder.Entity<Moderation>(entity =>
        {
            entity.HasKey(e => e.ModerationId).HasName("PK_mod_Moderation");

            entity.ToTable("Moderation", "mod");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ModerationContext>(entity =>
        {
            entity.HasKey(e => e.ModerationContextId).HasName("PK_mod_ModerationContext");

            entity.ToTable("ModerationContext", "mod");

            entity.HasIndex(e => e.HandleId, "IX_ModerationContext_HandleId");

            entity.Property(e => e.BlockingChangeDate).HasColumnType("datetime");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LockingChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ModerationStatus>(entity =>
        {
            entity.HasKey(e => e.ModerationStatusId).HasName("PK_mod_ModerationStatus");

            entity.ToTable("ModerationStatus", "mod");

            entity.Property(e => e.ModerationStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MonthlyPlan>(entity =>
        {
            entity.ToTable("MonthlyPlan", "sales");

            entity.Property(e => e.Invoices).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Payments).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<MonthlyPlanItem>(entity =>
        {
            entity.ToTable("MonthlyPlanItem", "sales");

            entity.Property(e => e.ProductCode).HasMaxLength(128);
        });

        modelBuilder.Entity<MonthlyPlanProductType>(entity =>
        {
            entity.ToTable("MonthlyPlanProductType", "sales");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification", "crm");

            entity.Property(e => e.ActualProcessDate).HasColumnType("datetime");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(256);
            entity.Property(e => e.ScheduledProcessDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<NotificationChannel>(entity =>
        {
            entity.ToTable("NotificationChannel", "crm");

            entity.Property(e => e.NotificationChannelId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<NotificationStatus>(entity =>
        {
            entity.ToTable("NotificationStatus", "crm");

            entity.Property(e => e.NotificationStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<NotificationSubType>(entity =>
        {
            entity.ToTable("NotificationSubType", "crm");

            entity.Property(e => e.NotificationSubTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<NotificationTargetEntityType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotificationTargetEntityType", "crm");

            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.ToTable("NotificationType", "crm");

            entity.Property(e => e.NotificationTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<ObjectHashCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_system_EntityHashCode");

            entity.ToTable("ObjectHashCode", "system");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.HashCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
        });

        modelBuilder.Entity<OccupationCategory>(entity =>
        {
            entity.HasKey(e => e.OccupationCategoryId).HasName("PK_common_OccupationCategory");

            entity.ToTable("OccupationCategory", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName).HasMaxLength(250);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_store_Order");

            entity.ToTable("Order", "store");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartialShippingDate).HasColumnType("datetime");
            entity.Property(e => e.ProFormaInvoiceFileId).HasMaxLength(500);
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK_store_Order_Item");

            entity.ToTable("Order_Item", "store");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<OrderShippingStatus>(entity =>
        {
            entity.ToTable("OrderShippingStatus", "store");

            entity.Property(e => e.OrderShippingStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.ToTable("OrderStatus", "store");

            entity.Property(e => e.OrderStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment", "billing");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmountLeft).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.LastAmountEditDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PaymentChannel>(entity =>
        {
            entity.HasKey(e => e.PaymentChannelId).HasName("PK_billing_PaymentChannel");

            entity.ToTable("PaymentChannel", "billing");

            entity.Property(e => e.PaymentChannelId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PK_billing_PaymentMethod");

            entity.ToTable("PaymentMethod", "billing");

            entity.Property(e => e.PaymentMethodId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId).HasName("PK_billing_PaymentStatus");

            entity.ToTable("PaymentStatus", "billing");

            entity.Property(e => e.PaymentStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.HasKey(e => e.PaymentTypeId).HasName("PK_billing_PaymentType");

            entity.ToTable("PaymentType", "billing");

            entity.Property(e => e.PaymentTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.ToTable("Portfolio", "client");

            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PortfolioAccountManager>(entity =>
        {
            entity.ToTable("Portfolio_AccountManager", "client");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PortfolioCustomer>(entity =>
        {
            entity.ToTable("Portfolio_Customer", "client");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PostingChannel>(entity =>
        {
            entity.ToTable("PostingChannel", "comments");

            entity.Property(e => e.PostingChannelId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_store_Product");

            entity.ToTable("Product", "store");

            entity.Property(e => e.Code).HasMaxLength(128);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductAspect>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.ProductAspectId }).HasName("PK_store_Product_Aspect");

            entity.ToTable("Product_Aspect", "store");

            entity.Property(e => e.ProductAspectId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductAspect1>(entity =>
        {
            entity.HasKey(e => e.ProductAspectId).HasName("PK_store_ProductAspect");

            entity.ToTable("ProductAspect", "store");

            entity.Property(e => e.ProductAspectId)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductCombinationConstraint>(entity =>
        {
            entity.ToTable("ProductCombinationConstraint", "constraints");
        });

        modelBuilder.Entity<ProductGroup>(entity =>
        {
            entity.ToTable("ProductGroup", "store");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductGroupProduct>(entity =>
        {
            entity.HasKey(e => e.ProducGroupProductId);

            entity.ToTable("ProductGroup_Product", "store");
        });

        modelBuilder.Entity<ProductIncompatibilityConstraint>(entity =>
        {
            entity.ToTable("ProductIncompatibilityConstraint", "constraints");
        });

        modelBuilder.Entity<ProductReplacementConstraint>(entity =>
        {
            entity.ToTable("ProductReplacementConstraint", "constraints");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.ProductTypeId).HasName("PK_store_ProductType");

            entity.ToTable("ProductType", "store");

            entity.Property(e => e.ProductTypeId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<ProductTypeAvailabilityConstraint>(entity =>
        {
            entity.ToTable("ProductTypeAvailabilityConstraint", "constraints");
        });

        modelBuilder.Entity<ProductTypeCombinationConstraint>(entity =>
        {
            entity.ToTable("ProductTypeCombinationConstraint", "constraints");
        });

        modelBuilder.Entity<ProductUpgradeConstraint>(entity =>
        {
            entity.ToTable("ProductUpgradeConstraint", "constraints");
        });

        modelBuilder.Entity<PromoEmailAttachment>(entity =>
        {
            entity.ToTable("PromoEmailAttachment", "messaging");

            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.Filename).HasMaxLength(500);
        });

        modelBuilder.Entity<PromoEmailPortfolio>(entity =>
        {
            entity.ToTable("PromoEmail_Portfolio", "messaging");
        });

        modelBuilder.Entity<PromoEmailStatus>(entity =>
        {
            entity.ToTable("PromoEmailStatus", "messaging");

            entity.Property(e => e.PromoEmailStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PromoEmailTemplate>(entity =>
        {
            entity.ToTable("PromoEmailTemplate", "messaging");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Subject).HasMaxLength(128);
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProviderWebsite>(entity =>
        {
            entity.HasKey(e => e.ProviderWebsiteId).HasName("PK_system_ProviderWebsite");

            entity.ToTable("ProviderWebsite", "system");

            entity.Property(e => e.ProviderWebsiteId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.LogoFileName).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Url).HasMaxLength(200);
        });

        modelBuilder.Entity<ProviderWebsiteOccupationCategory>(entity =>
        {
            entity.ToTable("ProviderWebsite_OccupationCategory", "system");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_audit_Record");

            entity.ToTable("Record", "audit");

            entity.Property(e => e.Attribute)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Context)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntityObjectId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK_mod_Request");

            entity.ToTable("Request", "mod");

            entity.HasIndex(e => e.HandleId, "IX_Request_HandleId");

            entity.HasIndex(e => e.IsFulfilled, "IX_Request_IsFulfilled");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FulfilDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RequestAction>(entity =>
        {
            entity.HasKey(e => e.RequestActionId).HasName("PK_mod_RequestAction");

            entity.ToTable("RequestAction", "mod");

            entity.Property(e => e.RequestActionId).ValueGeneratedNever();
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PK_ux_Resource");

            entity.ToTable("Resource", "ux");

            entity.HasIndex(e => new { e.ResourceScopeId, e.Name, e.ProviderWebsiteId }, "UN_ResourceScopeId_Name_ProviderWebsiteId").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Value).HasColumnType("ntext");
        });

        modelBuilder.Entity<ResourceI18n>(entity =>
        {
            entity.HasKey(e => e.ResourceI18nId).HasName("PK_ux_ResourceI18n");

            entity.ToTable("ResourceI18n", "ux");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Value).HasColumnType("ntext");
        });

        modelBuilder.Entity<ResourceScope>(entity =>
        {
            entity.HasKey(e => e.ResourceScopeId).HasName("PK_ux_ResourceScope");

            entity.ToTable("ResourceScope", "ux");

            entity.Property(e => e.ResourceScopeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_auth_Role");

            entity.ToTable("Role", "auth");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName).HasMaxLength(100);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<RoleFeature>(entity =>
        {
            entity.HasKey(e => e.RoleFeatureId).HasName("PK_auth_RoleFeature");

            entity.ToTable("RoleFeature", "auth");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SchemaVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SchemaVersions_Id");

            entity.Property(e => e.Applied).HasColumnType("datetime");
            entity.Property(e => e.ScriptName).HasMaxLength(255);
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.HasKey(e => e.SellerId).HasName("PK_store_Seller");

            entity.ToTable("Seller", "store");

            entity.Property(e => e.LogoUrl)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.WebsiteUrl)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK_auth_Session");

            entity.ToTable("Session", "auth");

            entity.Property(e => e.AbsoluteExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationSetDate).HasColumnType("datetime");
            entity.Property(e => e.LastAccessDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK_ux_Setting");

            entity.ToTable("Setting", "ux");

            entity.Property(e => e.SettingId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.KeyName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SettingI18n>(entity =>
        {
            entity.HasKey(e => e.SettingI18nId).HasName("PK_ux_SettingI18n");

            entity.ToTable("SettingI18n", "ux");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<SettingLevel>(entity =>
        {
            entity.HasKey(e => e.SettingLevelId).HasName("PK_ux_SettingLevel");

            entity.ToTable("SettingLevel", "ux");

            entity.Property(e => e.SettingLevelId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SliderBanner>(entity =>
        {
            entity.ToTable("SliderBanner", "client");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SliderBannerStatus>(entity =>
        {
            entity.HasKey(e => e.SliderBannerStatus1);

            entity.ToTable("SliderBannerStatus", "client");

            entity.Property(e => e.SliderBannerStatus1)
                .ValueGeneratedNever()
                .HasColumnName("SliderBannerStatus");
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SmsMessage>(entity =>
        {
            entity.ToTable("SmsMessage", "messaging");

            entity.Property(e => e.Address)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Content).HasMaxLength(2048);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SmsStatus>(entity =>
        {
            entity.ToTable("SmsStatus", "messaging");

            entity.Property(e => e.SmsStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<SmsStopReason>(entity =>
        {
            entity.ToTable("Sms_StopReason", "messaging");
        });

        modelBuilder.Entity<SmsStopReason1>(entity =>
        {
            entity.HasKey(e => e.SmsStopReasonId);

            entity.ToTable("SmsStopReason", "messaging");

            entity.Property(e => e.SmsStopReasonId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<SmsTemplate>(entity =>
        {
            entity.ToTable("SmsTemplate", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        modelBuilder.Entity<SmsTemplateContent>(entity =>
        {
            entity.ToTable("SmsTemplateContent", "messaging");

            entity.Property(e => e.Content).HasMaxLength(4000);
        });

        modelBuilder.Entity<SmsType>(entity =>
        {
            entity.ToTable("SmsType", "messaging");

            entity.Property(e => e.SmsTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<SpecialPriceOffer>(entity =>
        {
            entity.ToTable("SpecialPriceOffer", "store");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<StaticContent>(entity =>
        {
            entity.HasKey(e => e.StaticContentId).HasName("PK_ux_StaticContent");

            entity.ToTable("StaticContent", "ux");

            entity.Property(e => e.Alias).HasMaxLength(100);
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity.HasKey(e => e.SubscriberId).HasName("PK_client_Subscriber");

            entity.ToTable("Subscriber", "client");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailVerificationResendToken).HasMaxLength(50);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SubscriberCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SubscriberLocalitySubscription>(entity =>
        {
            entity.ToTable("Subscriber_LocalitySubscription", "client");
        });

        modelBuilder.Entity<SubscriberOccupationCategory>(entity =>
        {
            entity.HasKey(e => e.SubscriberOccupationCategoryId).HasName("PK_client_Subscriber_OccupationCategory");

            entity.ToTable("Subscriber_OccupationCategory", "client");
        });

        modelBuilder.Entity<SubscriberStatus>(entity =>
        {
            entity.HasKey(e => e.SubscriberStatusId).HasName("PK_client_SubscriberStatus");

            entity.ToTable("SubscriberStatus", "client");

            entity.Property(e => e.SubscriberStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SuspendedEmailAddress>(entity =>
        {
            entity.ToTable("SuspendedEmailAddress", "client");

            entity.HasIndex(e => new { e.EmailAddress, e.IsSuspended, e.IsDomain, e.IsProcessed }, "IX_SuspendedEmailAddress_EmailAddress_IsSuspended_IsDomain_IsProcessed");

            entity.Property(e => e.BounceSubType).HasMaxLength(50);
            entity.Property(e => e.BounceType).HasMaxLength(50);
            entity.Property(e => e.ComplaintType).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.EmailDomain).HasMaxLength(50);
            entity.Property(e => e.SuspendType).HasMaxLength(50);
        });

        modelBuilder.Entity<SystemConfig>(entity =>
        {
            entity.HasKey(e => e.SystemConfigId).HasName("PK_common_SystemConfig");

            entity.ToTable("SystemConfig", "system");

            entity.HasIndex(e => new { e.KeyName, e.IsProviderWebsiteSpecific, e.ProviderWebsiteId }, "DataCompareKey_Unique");

            entity.Property(e => e.SystemConfigId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.KeyName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
            entity.Property(e => e.ValueObject).HasMaxLength(4000);
        });

        modelBuilder.Entity<TargetAudience>(entity =>
        {
            entity.HasKey(e => e.TargetAudienceId).HasName("PK_posting_TargetAudience");

            entity.ToTable("TargetAudience", "posting");

            entity.Property(e => e.TargetAudienceId).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK_messaging_Template");

            entity.ToTable("Template", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmaiTemplateGenerationPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KeyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TemplateContent>(entity =>
        {
            entity.HasKey(e => e.TemplateContentId).HasName("PK_messaging_TemplateContent");

            entity.ToTable("TemplateContent", "messaging");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(500);
        });

        modelBuilder.Entity<TermTag>(entity =>
        {
            entity.HasKey(e => e.TermTagId).HasName("PK_indexing_TermTag");

            entity.ToTable("TermTag", "indexing");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Text)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TermTagRelation>(entity =>
        {
            entity.HasKey(e => e.TermTagRelationId).HasName("PK_indexing_TermTagRelation");

            entity.ToTable("TermTagRelation", "indexing");
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.HasKey(e => e.ThemeId).HasName("PK_ux_Theme");

            entity.ToTable("Theme", "ux");

            entity.Property(e => e.ThemeId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Thread>(entity =>
        {
            entity.ToTable("Thread", "comments");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastPostDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ThreadPost>(entity =>
        {
            entity.ToTable("ThreadPost", "comments");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ThreadRelatedObjectType>(entity =>
        {
            entity.HasKey(e => e.ThreadRelatedObjectType1);

            entity.ToTable("ThreadRelatedObjectType", "comments");

            entity.Property(e => e.ThreadRelatedObjectType1)
                .ValueGeneratedNever()
                .HasColumnName("ThreadRelatedObjectType");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ThreadTopic>(entity =>
        {
            entity.ToTable("ThreadTopic", "comments");

            entity.Property(e => e.ThreadTopicId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TransactionApprovalStatus>(entity =>
        {
            entity.ToTable("TransactionApprovalStatus", "billing");

            entity.Property(e => e.TransactionApprovalStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TransactionInvoice>(entity =>
        {
            entity.ToTable("Transaction_Invoice", "billing");
        });

        modelBuilder.Entity<TransactionRecord>(entity =>
        {
            entity.ToTable("TransactionRecord", "billing");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.ConfirmationEmailSendDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FinalApproveDate).HasColumnType("datetime");
            entity.Property(e => e.InitialCompleteApproveDate).HasColumnType("datetime");
            entity.Property(e => e.InitialPartialApproveDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceTotalAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastOrderEditDate).HasColumnType("datetime");
            entity.Property(e => e.LastOrderTotalAmountWithDiscountEditDate).HasColumnType("datetime");
            entity.Property(e => e.LastPayerEditDate).HasColumnType("datetime");
            entity.Property(e => e.LastSendProformaInvoiceFileId).HasMaxLength(50);
            entity.Property(e => e.OrderTotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotalAmountWithDiscount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OriginalProFormaInvoiceFileId).HasMaxLength(500);
            entity.Property(e => e.ProFormaInvoiceFileId).HasMaxLength(500);
            entity.Property(e => e.ProFormaInvoiceSendDate).HasColumnType("datetime");
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.ReverseDate).HasColumnType("datetime");
            entity.Property(e => e.TaxesTotalAmount).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<TransactionStatus>(entity =>
        {
            entity.ToTable("TransactionStatus", "billing");

            entity.Property(e => e.TransactionStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_common_User");

            entity.ToTable("UserAccount", "common");

            entity.HasIndex(e => e.Email, "IX_User_Email");

            entity.HasIndex(e => e.Username, "IX_Username_CustomerAgent_Admin_Unique").IsUnique();

            entity.HasIndex(e => new { e.Username, e.OriginWebsiteId }, "IX_Username_Jobseeker_Unique").IsUnique();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailVerificationResendToken).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.LastVisitDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<UserFeature>(entity =>
        {
            entity.HasKey(e => e.UserFeatureId).HasName("PK_auth_UserFeature");

            entity.ToTable("UserFeature", "auth");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserPreference>(entity =>
        {
            entity.HasKey(e => e.UserPreferenceId).HasName("PK_ux_UserPreference");

            entity.ToTable("UserPreference", "ux");

            entity.Property(e => e.ValueDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK_auth_UserRole");

            entity.ToTable("UserRole", "auth");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserSmsLanguageCharset>(entity =>
        {
            entity.ToTable("UserSmsLanguageCharset", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserStatus>(entity =>
        {
            entity.HasKey(e => e.UserStatusId).HasName("PK_common_UserStatus");

            entity.ToTable("UserStatus", "common");

            entity.Property(e => e.UserStatusId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UserStoppedEmail>(entity =>
        {
            entity.ToTable("UserStoppedEmail", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserStoppedSm>(entity =>
        {
            entity.HasKey(e => e.UserStoppedSmsId);

            entity.ToTable("UserStoppedSms", "messaging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK_common_UserType");

            entity.ToTable("UserType", "common");

            entity.Property(e => e.UserTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Vatstatus>(entity =>
        {
            entity.HasKey(e => e.VatstatusId).HasName("PK_billing_VATStatus");

            entity.ToTable("VATStatus", "billing");

            entity.Property(e => e.VatstatusId)
                .ValueGeneratedNever()
                .HasColumnName("VATStatusId");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorldLanguage>(entity =>
        {
            entity.HasKey(e => e.WorldLanguageId).HasName("PK_common_WorldLanguage");

            entity.ToTable("WorldLanguage", "common");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
