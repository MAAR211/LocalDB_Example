using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example_3.Migrations
{
    /// <inheritdoc />
    public partial class LocalPreprodMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "billing");

            migrationBuilder.EnsureSchema(
                name: "audit");

            migrationBuilder.EnsureSchema(
                name: "client");

            migrationBuilder.EnsureSchema(
                name: "posting");

            migrationBuilder.EnsureSchema(
                name: "matching");

            migrationBuilder.EnsureSchema(
                name: "feeds");

            migrationBuilder.EnsureSchema(
                name: "constraints");

            migrationBuilder.EnsureSchema(
                name: "ads");

            migrationBuilder.EnsureSchema(
                name: "mod");

            migrationBuilder.EnsureSchema(
                name: "common");

            migrationBuilder.EnsureSchema(
                name: "store");

            migrationBuilder.EnsureSchema(
                name: "meta");

            migrationBuilder.EnsureSchema(
                name: "messaging");

            migrationBuilder.EnsureSchema(
                name: "indexing");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.EnsureSchema(
                name: "system");

            migrationBuilder.EnsureSchema(
                name: "ux");

            migrationBuilder.EnsureSchema(
                name: "sales");

            migrationBuilder.EnsureSchema(
                name: "crm");

            migrationBuilder.EnsureSchema(
                name: "comments");

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "billing",
                columns: table => new
                {
                    AccountId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    AccountStatusId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    VATStatusId = table.Column<int>(type: "int", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    AvailableAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "AccountStatus",
                schema: "billing",
                columns: table => new
                {
                    AccountStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_AccountStatus", x => x.AccountStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Action",
                schema: "audit",
                columns: table => new
                {
                    ActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SourceUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audit_Action", x => x.ActionId);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                schema: "client",
                columns: table => new
                {
                    AdminId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    lastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneExtension = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MobileNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    AnnouncementStatusId = table.Column<int>(type: "int", nullable: false),
                    AnnouncementTypeId = table.Column<int>(type: "int", nullable: false),
                    AnnouncementModuleId = table.Column<int>(type: "int", nullable: true),
                    IsPriority = table.Column<bool>(type: "bit", nullable: true),
                    PriorityUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWithLogo = table.Column<bool>(type: "bit", nullable: false),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CustomerName2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ApplicationMethodId = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeadlineDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContactCustomerAgentId = table.Column<long>(type: "bigint", nullable: true),
                    TargetAudienceId = table.Column<int>(type: "int", nullable: true),
                    EmploymentFormId = table.Column<int>(type: "int", nullable: true),
                    IsTravelRequired = table.Column<bool>(type: "bit", nullable: true),
                    SalaryFrom = table.Column<int>(type: "int", nullable: true),
                    SalaryTo = table.Column<int>(type: "int", nullable: true),
                    DurationFrom = table.Column<int>(type: "int", nullable: true),
                    DurationTo = table.Column<int>(type: "int", nullable: true),
                    WorkExperienceFrom = table.Column<int>(type: "int", nullable: true),
                    WorkExperienceTo = table.Column<int>(type: "int", nullable: true),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true),
                    HideSalary = table.Column<bool>(type: "bit", nullable: true),
                    HideContactPerson = table.Column<bool>(type: "bit", nullable: false),
                    HideLocationExceptCity = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InsertUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    AnnouncementListingSectionId = table.Column<int>(type: "int", nullable: true),
                    PublishStatusId = table.Column<int>(type: "int", nullable: false),
                    RenewalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWithFrame = table.Column<bool>(type: "bit", nullable: false),
                    IsWithNewYearBauble = table.Column<bool>(type: "bit", nullable: false),
                    IsWithNewYearDecoration = table.Column<bool>(type: "bit", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: true),
                    BaubleTypeId = table.Column<int>(type: "int", nullable: true),
                    NewYearDecorationTypeId = table.Column<int>(type: "int", nullable: true),
                    IsFacebookShareOn = table.Column<bool>(type: "bit", nullable: false),
                    IsLinkedInShareOn = table.Column<bool>(type: "bit", nullable: false),
                    LastRenewalId = table.Column<long>(type: "bigint", nullable: true),
                    IsEventSpecific = table.Column<bool>(type: "bit", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    DescriptionPlainText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description2PlainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWithBonus = table.Column<bool>(type: "bit", nullable: false),
                    IsInstagramShareOn = table.Column<bool>(type: "bit", nullable: false),
                    IsMatchingEligible = table.Column<bool>(type: "bit", nullable: false),
                    IsMatchingReady = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForStudent = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkFromHome = table.Column<bool>(type: "bit", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: true),
                    WorkExperienceType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement", x => x.AnnouncementId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_ApplicationDetail",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsEmailSameAsContactPerson = table.Column<bool>(type: "bit", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsPhoneSameAsContactPerson = table.Column<bool>(type: "bit", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ForwardApplicationsToEmail = table.Column<bool>(type: "bit", nullable: true),
                    RecipientCustomerAgentId = table.Column<bool>(type: "bit", nullable: true),
                    ApplicationUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ApplicationAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_ApplicationDetail", x => x.AnnouncementId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Attachment",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_Attachment", x => x.AnnouncementId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_DistributionChannel",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementDistributionChannelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    DistributionChannelId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AnnouncementListingSectionId = table.Column<int>(type: "int", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    PriorityUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsWithLogo = table.Column<bool>(type: "bit", nullable: false),
                    IsWithFrame = table.Column<bool>(type: "bit", nullable: false),
                    IsWithNewYearBauble = table.Column<bool>(type: "bit", nullable: false),
                    IsWithNewYearDecoration = table.Column<bool>(type: "bit", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: true),
                    BaubleTypeId = table.Column<int>(type: "int", nullable: true),
                    NewYearDecorationTypeId = table.Column<int>(type: "int", nullable: true),
                    IsFacebookShareOn = table.Column<bool>(type: "bit", nullable: false),
                    PriorityDays = table.Column<int>(type: "int", nullable: true),
                    AnnouncementModuleId = table.Column<int>(type: "int", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeadlineDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    RenewalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PriorityExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPreview = table.Column<bool>(type: "bit", nullable: false),
                    DetailsDistributionChannelId = table.Column<int>(type: "int", nullable: true),
                    PriorityActivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_DistributionChannel", x => x.AnnouncementDistributionChannelId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_DrivingLicence",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementDrivingLicenceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    DrivingLicenceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_DrivingLicense", x => x.AnnouncementDrivingLicenceId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Language",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementLanguageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    WorldLanguageId = table.Column<long>(type: "bigint", nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_Language", x => x.AnnouncementLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Locality",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementLocalityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_Locality", x => x.AnnouncementLocalityId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Location",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementLocationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerLocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_Location", x => x.AnnouncementLocationId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Logo",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    LogoFilename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LogoThumbnail1Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_Logo", x => x.AnnouncementId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_MatchingList",
                schema: "matching",
                columns: table => new
                {
                    AnnouncementMatchingListId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    IsAutoGenerated = table.Column<bool>(type: "bit", nullable: false),
                    IsRegenerated = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    ApprovalStatusId = table.Column<int>(type: "int", nullable: false),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    PlannedSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsEmailGenerated = table.Column<bool>(type: "bit", nullable: false),
                    EmailMessageId = table.Column<long>(type: "bigint", nullable: true),
                    GenerationStatusId = table.Column<int>(type: "int", nullable: false),
                    LastGenerationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    IsCvAccessActive = table.Column<bool>(type: "bit", nullable: false),
                    CvAccessDays = table.Column<int>(type: "int", nullable: true),
                    CvAccessExpireDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement_MatchingList", x => x.AnnouncementMatchingListId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_OccupationCategory",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementOccupationCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    OccupationCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_Announcement_OccupationCategory", x => x.AnnouncementOccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Stat",
                schema: "posting",
                columns: table => new
                {
                    Announcement_StatId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    TotalViewCount = table.Column<int>(type: "int", nullable: true),
                    AnonymousViewCount = table.Column<int>(type: "int", nullable: false),
                    NonAnonymousViewCount = table.Column<int>(type: "int", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement_Stat", x => x.Announcement_StatId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementBaubleType",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementBaubleTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementBaubleType", x => x.AnnouncementBaubleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementDecorationType",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementDecorationTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementDecorationType", x => x.AnnouncementDecorationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementFeed",
                schema: "feeds",
                columns: table => new
                {
                    AnnouncementFeedId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    HasModeration = table.Column<bool>(type: "bit", nullable: false),
                    FilterObject = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementFeed", x => x.AnnouncementFeedId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementFeedMatch",
                schema: "feeds",
                columns: table => new
                {
                    AnnouncementFeedMatchId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementFeedId = table.Column<long>(type: "bigint", nullable: false),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementFeedMatch", x => x.AnnouncementFeedMatchId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementFeedMatchStatus",
                schema: "feeds",
                columns: table => new
                {
                    AnnouncementFeedMatchStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Announce__61585BE7EF5A7716", x => x.AnnouncementFeedMatchStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementFrameType",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementFrameTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementFrameType", x => x.AnnouncementFrameTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementJobseekerApplication",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementJobseekerApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastViewDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementJobseekerApplication", x => x.AnnouncementJobseekerApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementListingSection",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementListingSectionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementListingSection", x => x.AnnouncementListingSectionId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementMatchingJobseeker",
                schema: "matching",
                columns: table => new
                {
                    AnnouncementMatchingJobseekerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementMatchingListId = table.Column<long>(type: "bigint", nullable: true),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentPositionFinalScore = table.Column<double>(type: "float", nullable: false),
                    BestPositionFinalScore = table.Column<double>(type: "float", nullable: false),
                    BestPositionAgePenalty = table.Column<double>(type: "float", nullable: false),
                    BestPositionKeywordScore = table.Column<double>(type: "float", nullable: false),
                    CurrentCategoryFinalScore = table.Column<double>(type: "float", nullable: false),
                    CurrentSubCategoryScore = table.Column<double>(type: "float", nullable: false),
                    CurrentHeadCategoryScore = table.Column<double>(type: "float", nullable: false),
                    BestCategoryFinalScore = table.Column<double>(type: "float", nullable: false),
                    BestSubCategoryScore = table.Column<double>(type: "float", nullable: false),
                    BestHeadCategoryScore = table.Column<double>(type: "float", nullable: false),
                    CurrentAggregatedCategoryFinalScore = table.Column<double>(type: "float", nullable: false),
                    CurrentAggregatedSubCategoryScore = table.Column<double>(type: "float", nullable: false),
                    CurrentAggregatedHeadCategoryScore = table.Column<double>(type: "float", nullable: false),
                    BestAggregatedCategoryFinalScore = table.Column<double>(type: "float", nullable: false),
                    BestAggregatedSubCategoryScore = table.Column<double>(type: "float", nullable: false),
                    BestAggregatedHeadCategoryScore = table.Column<double>(type: "float", nullable: false),
                    LanguageFinalScore = table.Column<double>(type: "float", nullable: false),
                    DrivingLicenseFinalScore = table.Column<double>(type: "float", nullable: false),
                    LocationFinalScore = table.Column<double>(type: "float", nullable: false),
                    ExperienceFinalScore = table.Column<double>(type: "float", nullable: false),
                    ExperienceSubCategoryScore = table.Column<double>(type: "float", nullable: false),
                    ExperienceHeadCategoryScore = table.Column<double>(type: "float", nullable: false),
                    FinalScore = table.Column<double>(type: "float", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    LastStatusUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastStatusUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    PositionFinalScore = table.Column<double>(type: "float", nullable: false),
                    CategoryFinalScore = table.Column<double>(type: "float", nullable: false),
                    MandatoryLanguageScore = table.Column<double>(type: "float", nullable: false),
                    OptionalLanguageScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Announce__F34165ECFE14E96B", x => x.AnnouncementMatchingJobseekerId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementMatchingJobseekerStatus",
                schema: "matching",
                columns: table => new
                {
                    AnnouncementMatchingJobseekerStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementMatchingJobseekerStatus", x => x.AnnouncementMatchingJobseekerStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementMatchingListApprovalStatus",
                schema: "matching",
                columns: table => new
                {
                    AnnouncementMatchingListApprovalStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementMatchingListApprovalStatus", x => x.AnnouncementMatchingListApprovalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementMatchingListGenerationStatus",
                schema: "matching",
                columns: table => new
                {
                    AnnouncementMatchingListGenerationStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementMatchingListGenerationStatus", x => x.AnnouncementMatchingListGenerationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementModule",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementModuleId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementModule", x => x.AnnouncementModuleId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementPublishStatus",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementPublishStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementPublishStatus", x => x.AnnouncementPublishStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementRenewal",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementRenewalId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: false),
                    ScheduledRenewalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualRenewalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsInstant = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementRenewal", x => x.AnnouncementRenewalId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementRenewal_Stat",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementRenewalStatId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementRenewalId = table.Column<long>(type: "bigint", nullable: false),
                    TotalViewCount = table.Column<int>(type: "int", nullable: true),
                    AnonymousViewCount = table.Column<int>(type: "int", nullable: false),
                    NonAnonymousViewCount = table.Column<int>(type: "int", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementRenewal_Stat", x => x.AnnouncementRenewalStatId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementSite",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementSiteId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementSite", x => x.AnnouncementSiteId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementStatus",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementStatus", x => x.AnnouncementStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementType",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementType", x => x.AnnouncementTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementTypeSecondaryProductConstraint",
                schema: "constraints",
                columns: table => new
                {
                    AnnouncementTypeSecondaryProductConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryProductTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryProductId = table.Column<int>(type: "int", nullable: true),
                    IsProviderSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementTypeSecondaryProductConstraint", x => x.AnnouncementTypeSecondaryProductConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementWorkExperienceType",
                schema: "posting",
                columns: table => new
                {
                    AnnouncementWorkExperienceTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsActive = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementWorkExperienceType", x => x.AnnouncementWorkExperienceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationMethod",
                schema: "posting",
                columns: table => new
                {
                    ApplicationMethodId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_ApplicationMethod", x => x.ApplicationMethodId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                schema: "posting",
                columns: table => new
                {
                    ApplicationStatusId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_AnnouncementApplicationStatus", x => x.ApplicationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                schema: "billing",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_Bank", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                schema: "ads",
                columns: table => new
                {
                    BannerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastActivationUserId = table.Column<int>(type: "int", nullable: true),
                    DeactivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsOpenNewTab = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "BannerClickEvent",
                schema: "ads",
                columns: table => new
                {
                    BannerClickEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerClickEvent", x => x.BannerClickEventId);
                });

            migrationBuilder.CreateTable(
                name: "BannerPosition",
                schema: "ads",
                columns: table => new
                {
                    BannerPositionId = table.Column<int>(type: "int", nullable: false),
                    HeadBannerPositionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DesktopWidth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DesktopHeight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResponsiveWidth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResponsiveHeight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPosition", x => x.BannerPositionId);
                });

            migrationBuilder.CreateTable(
                name: "BannerStatus",
                schema: "ads",
                columns: table => new
                {
                    BannerStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerStatus", x => x.BannerStatusId);
                });

            migrationBuilder.CreateTable(
                name: "BannerTarget",
                schema: "ads",
                columns: table => new
                {
                    BannerTargetId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerTarget", x => x.BannerTargetId);
                });

            migrationBuilder.CreateTable(
                name: "BannerType",
                schema: "ads",
                columns: table => new
                {
                    BannerTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerType", x => x.BannerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BannerViewEvent",
                schema: "ads",
                columns: table => new
                {
                    BannerViewEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerViewEvent", x => x.BannerViewEventId);
                });

            migrationBuilder.CreateTable(
                name: "BasePlacementSectionSecondaryProductConstraint",
                schema: "constraints",
                columns: table => new
                {
                    BasePlacementSectionSecondaryProductConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePlacementSectionId = table.Column<int>(type: "int", nullable: false),
                    SecondaryProductTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryProductId = table.Column<int>(type: "int", nullable: true),
                    IsProviderSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePlacementSectionSecondaryProductConstraint", x => x.BasePlacementSectionSecondaryProductConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "BoothType",
                schema: "posting",
                columns: table => new
                {
                    BoothTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoothType", x => x.BoothTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BrandingAnnouncementTileType",
                schema: "client",
                columns: table => new
                {
                    BrandingAnnouncementTileTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandingAnnouncementTileType", x => x.BrandingAnnouncementTileTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                schema: "mod",
                columns: table => new
                {
                    ContentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    EntityAttributeId = table.Column<int>(type: "int", nullable: false),
                    ContentActionId = table.Column<int>(type: "int", nullable: false),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    IsOverridden = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDirectEntityReference = table.Column<bool>(type: "bit", nullable: true),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    CurrentValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    CurrentValueBool = table.Column<bool>(type: "bit", nullable: true),
                    CurrentValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrentValueFloat = table.Column<double>(type: "float", nullable: true),
                    NewValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    NewValueBool = table.Column<bool>(type: "bit", nullable: true),
                    NewValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NewValueFloat = table.Column<double>(type: "float", nullable: true),
                    NewValueHashCode = table.Column<long>(type: "bigint", nullable: true),
                    ModerationId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_Content", x => x.ContentId);
                });

            migrationBuilder.CreateTable(
                name: "ContentAction",
                schema: "mod",
                columns: table => new
                {
                    ContentActionId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_ContentAction", x => x.ContentActionId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "common",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alpha2Code = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Alpha3Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    NumericCode = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "client",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerStatusId = table.Column<int>(type: "int", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LegalName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LegalAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LegalAddress2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LocalityId = table.Column<int>(type: "int", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PublicEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfEmployeesFrom = table.Column<int>(type: "int", nullable: true),
                    NumberOfEmployeesTo = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InsertUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    VerificationExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LegacyContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LastAutomaticEmailSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextDebtRemindDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HasFeeds = table.Column<bool>(type: "bit", nullable: false),
                    InactiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InactiveUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Group",
                schema: "client",
                columns: table => new
                {
                    CustomerGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Group", x => x.CustomerGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_IgnoredCustomer",
                schema: "feeds",
                columns: table => new
                {
                    CustomerIgnoredCustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    IgnoredCustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_IgnoredCustomer", x => x.CustomerIgnoredCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAgent",
                schema: "client",
                columns: table => new
                {
                    CustomerAgentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerAgentStatusId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    IsProfileOwner = table.Column<bool>(type: "bit", nullable: false),
                    IsVirtualAdminAgent = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone1Number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1Extension = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MobilePhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobilePhoneNumber2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerAgent", x => x.CustomerAgentId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAgentStatus",
                schema: "client",
                columns: table => new
                {
                    CustomerAgentStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerAgentStatus", x => x.CustomerAgentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAutomaticEmail",
                schema: "client",
                columns: table => new
                {
                    CustomerAutomaticEmailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    EmailTypeId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAutomaticEmail", x => x.CustomerAutomaticEmailId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAutomaticSms",
                schema: "client",
                columns: table => new
                {
                    CustomerAutomaticSmsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    SmsTypeId = table.Column<int>(type: "int", nullable: false),
                    ContentInfo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SmsMessageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAutomaticSms", x => x.CustomerAutomaticSmsId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBranding",
                schema: "client",
                columns: table => new
                {
                    CustomerBrandingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AnnouncementDetailsDesktopBgImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AnnouncementDetailsMobileBgImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CustomerCoverImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AnnouncementDetailsBgColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    AnnouncementTileColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAnnouncementDetailsBackgroundColorCustomizable = table.Column<bool>(type: "bit", nullable: true),
                    IsAnnouncementDetailsCoverPhotoCustomizable = table.Column<bool>(type: "bit", nullable: true),
                    AnnouncementDetailsDisplayOtherAnnouncements = table.Column<bool>(type: "bit", nullable: true),
                    AnnouncementDetailsDisplayCvBox = table.Column<bool>(type: "bit", nullable: true),
                    IsCustomerDetailsBackgroundColorCustomizable = table.Column<bool>(type: "bit", nullable: true),
                    BrandingAnnouncementTileTypeId = table.Column<int>(type: "int", nullable: true),
                    CustomerDetailsBgColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBranding", x => x.CustomerBrandingId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBrandingAccessToken",
                schema: "client",
                columns: table => new
                {
                    CustomerBrandingAccessTokenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerBrandingId = table.Column<long>(type: "bigint", nullable: false),
                    IsAnnouncementDetailsBackgroundColorCustomizable = table.Column<bool>(type: "bit", nullable: false),
                    IsAnnouncementDetailsCoverPhotoCustomizable = table.Column<bool>(type: "bit", nullable: false),
                    AnnouncementDetailsDisplayOtherAnnouncements = table.Column<bool>(type: "bit", nullable: false),
                    AnnouncementDetailsDisplayCvBox = table.Column<bool>(type: "bit", nullable: false),
                    BrandingAnnouncementTileTypeId = table.Column<int>(type: "int", nullable: false),
                    IsCustomerDetailsBackgroundColorCustomizable = table.Column<bool>(type: "bit", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TokenExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestUserId = table.Column<long>(type: "bigint", nullable: false),
                    RequestCustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProcessUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminateUserId = table.Column<long>(type: "bigint", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBrandingAccessToken", x => x.CustomerBrandingAccessTokenId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBrandingAccessTokenStatus",
                schema: "client",
                columns: table => new
                {
                    CustomerBrandingAccessTokenStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBrandingAccessTokenStatus", x => x.CustomerBrandingAccessTokenStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBrandingType",
                schema: "client",
                columns: table => new
                {
                    CustomerBrandingTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBrandingType", x => x.CustomerBrandingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContract",
                schema: "client",
                columns: table => new
                {
                    CustomerContractId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContract", x => x.CustomerContractId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContractType",
                schema: "client",
                columns: table => new
                {
                    CustomerContractTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContractType", x => x.CustomerContractTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerGroup",
                schema: "client",
                columns: table => new
                {
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerGroup", x => x.CustomerGroupId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerJobseekerView",
                schema: "client",
                columns: table => new
                {
                    CustomerJobseekerViewId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastViewDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerJobseekerView", x => x.CustomerJobseekerViewId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerJobseekerViewEvent",
                schema: "client",
                columns: table => new
                {
                    JobseekerViewEventId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CvDatabaseAccessTokenId = table.Column<long>(type: "bigint", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: false),
                    CvBoxAccessTokenId = table.Column<long>(type: "bigint", nullable: true),
                    AnnouncementId = table.Column<long>(type: "bigint", nullable: true),
                    MatchingId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerJobseekerViewEvent", x => x.JobseekerViewEventId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerJobseekerViewEventSource",
                schema: "client",
                columns: table => new
                {
                    CustomerJobseekerViewEventSourceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerJobseekerViewEventSource", x => x.CustomerJobseekerViewEventSourceId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLocation",
                schema: "client",
                columns: table => new
                {
                    CustomerLocationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityLocalityId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Longitude = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Latitude = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerLocation", x => x.CustomerLocationId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLogo",
                schema: "client",
                columns: table => new
                {
                    CustomerLogoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    LogoFilename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LogoThumbnail1Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsUpdatingRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerLogo", x => x.CustomerLogoId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSavedJobseeker",
                schema: "client",
                columns: table => new
                {
                    CustomerSavedJobseekerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerSavedJobseekerFolderId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerSavedJobseeker", x => x.CustomerSavedJobseekerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSavedJobseekerFolder",
                schema: "client",
                columns: table => new
                {
                    CustomerSavedJobseekerFolderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    FolderName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerSavedJobseekerFolder", x => x.CustomerSavedJobseekerFolderId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerStatus",
                schema: "client",
                columns: table => new
                {
                    CustomerStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerStatus", x => x.CustomerStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                schema: "client",
                columns: table => new
                {
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_CustomerType", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypeBasePlacementSectionConstraint",
                schema: "constraints",
                columns: table => new
                {
                    CustomerTypeBasePlacementSectionConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    BasePlacementSectionId = table.Column<int>(type: "int", nullable: false),
                    IsProviderSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypeBasePlacementSectionConstraint", x => x.CustomerTypeBasePlacementSectionConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypeProductConstraint",
                schema: "constraints",
                columns: table => new
                {
                    CustomerTypeProductConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    IsProviderSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypeProductConstraint", x => x.CustomerTypeProductConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "CvBox",
                schema: "client",
                columns: table => new
                {
                    CvBoxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBox", x => x.CvBoxId);
                });

            migrationBuilder.CreateTable(
                name: "CvBoxAccessToken",
                schema: "client",
                columns: table => new
                {
                    CvBoxAccessTokenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvBoxId = table.Column<long>(type: "bigint", nullable: false),
                    PlaceInFrontPageCvTopSection = table.Column<bool>(type: "bit", nullable: false),
                    PlaceInCustomerProfileCvSection = table.Column<bool>(type: "bit", nullable: false),
                    PlaceInCvBoxPage = table.Column<bool>(type: "bit", nullable: false),
                    CvBoxPageSectionId = table.Column<int>(type: "int", nullable: true),
                    DecorateInCustomerAnnouncements = table.Column<bool>(type: "bit", nullable: false),
                    IsCvViewAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsCvSendAllowed = table.Column<bool>(type: "bit", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CvSendExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CvViewExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TokenExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProcessUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminateUserId = table.Column<long>(type: "bigint", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestCustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CvSendDayCount = table.Column<int>(type: "int", nullable: false),
                    CvViewDayCount = table.Column<int>(type: "int", nullable: false),
                    PlaceInFrontPageSliderSection = table.Column<bool>(type: "bit", nullable: false),
                    PlaceInAnnouncementDetailsSliderSection = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBoxAccessToken", x => x.CvBoxAccessTokenId);
                });

            migrationBuilder.CreateTable(
                name: "CvBoxAccessTokenStatus",
                schema: "client",
                columns: table => new
                {
                    CvBoxAccessTokenStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBoxAccessTokenStatus", x => x.CvBoxAccessTokenStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CvBoxItem",
                schema: "client",
                columns: table => new
                {
                    CvBoxItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvBoxId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CvBoxAccessTokenId = table.Column<long>(type: "bigint", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBoxItem", x => x.CvBoxItemId);
                });

            migrationBuilder.CreateTable(
                name: "CvBoxItemStatus",
                schema: "client",
                columns: table => new
                {
                    CvBoxItemStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBoxItemStatus", x => x.CvBoxItemStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CvBoxPageSection",
                schema: "client",
                columns: table => new
                {
                    CvBoxPageSectionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvBoxPageSection", x => x.CvBoxPageSectionId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessProductGroup",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessProductGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessProductGroup", x => x.CvDatabaseAccessProductGroupId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessProductGroup",
                schema: "store",
                columns: table => new
                {
                    CvDatabaseAccessProductGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CvDataba__AAA55836271D75B9", x => x.CvDatabaseAccessProductGroupId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessToken",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvDatabaseAccessTokenRequestId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    DemoViewCountLimit = table.Column<int>(type: "int", nullable: false),
                    TotalViewCountLimit = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TerminateUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProcessUserId = table.Column<long>(type: "bigint", nullable: true),
                    CvDatabaseAccessTokenTypeId = table.Column<int>(type: "int", nullable: false),
                    FullAccessDayCount = table.Column<int>(type: "int", nullable: false),
                    FullAccessExpireDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessToken", x => x.CvDatabaseAccessTokenId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessToken_CvDatabaseProvider",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenCvDatabaseProviderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvDatabaseAccessTokenId = table.Column<long>(type: "bigint", nullable: false),
                    CvDatabaseProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessToken_CvDatabaseProvider", x => x.CvDatabaseAccessTokenCvDatabaseProviderId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessToken_Event",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenEventId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvDatabaseAccessTokenId = table.Column<long>(type: "bigint", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessToken_Event", x => x.CvDatabaseAccessTokenEventId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessTokenRequest",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenRequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestUserId = table.Column<long>(type: "bigint", nullable: true),
                    RequestCustomerAgentId = table.Column<long>(type: "bigint", nullable: true),
                    RequestCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TerminateUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProcessUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessTokenRequest", x => x.CvDatabaseAccessTokenRequestId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessTokenRequestStatus",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenRequestStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessTokenRequestStatus", x => x.CvDatabaseAccessTokenRequestStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessTokenStatus",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessTokenStatus", x => x.CvDatabaseAccessTokenStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CvDatabaseAccessTokenType",
                schema: "client",
                columns: table => new
                {
                    CvDatabaseAccessTokenTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvDatabaseAccessTokenType", x => x.CvDatabaseAccessTokenTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DataType",
                schema: "meta",
                columns: table => new
                {
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meta_DataType", x => x.DataTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryFailure",
                schema: "messaging",
                columns: table => new
                {
                    DeliveryFailureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_DeliveryFailure", x => x.DeliveryFailureId);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicence",
                schema: "common",
                columns: table => new
                {
                    DrivingLicenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_DrivingLicence", x => x.DrivingLicenceId);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitution",
                schema: "common",
                columns: table => new
                {
                    EducationalInstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameLatin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LogoFilename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EducationalInstitutionTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationlInstitution", x => x.EducationalInstitutionId);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitutionType",
                schema: "common",
                columns: table => new
                {
                    EducationalInstitutionTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_EducatioalInstitutionType", x => x.EducationalInstitutionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EducationalProgram",
                schema: "common",
                columns: table => new
                {
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalInstitutionId = table.Column<int>(type: "int", nullable: false),
                    EducationalInstitutionCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    NameLatin = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NameShort = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalProgram", x => x.EducationalProgramId);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                schema: "common",
                columns: table => new
                {
                    EducationLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    RankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_EducationLevel", x => x.EducationLevelId);
                });

            migrationBuilder.CreateTable(
                name: "EmailAttachment",
                schema: "messaging",
                columns: table => new
                {
                    EmailAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailMessageId = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAttachment", x => x.EmailAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "EmailContent",
                schema: "messaging",
                columns: table => new
                {
                    EmailContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_EmailContent", x => x.EmailContentId);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessage",
                schema: "messaging",
                columns: table => new
                {
                    EmailMessageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FromTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ToAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CCAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BCCAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailContentId = table.Column<long>(type: "bigint", nullable: true),
                    EmailStatusId = table.Column<int>(type: "int", nullable: false),
                    DeliveryFailureId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAttemptCount = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<short>(type: "smallint", nullable: false),
                    TemplatKeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsTemporary = table.Column<bool>(type: "bit", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    EmailTypeId = table.Column<int>(type: "int", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_EmailMessage", x => x.EmailMessageId);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessageRecipient",
                schema: "messaging",
                columns: table => new
                {
                    EmailMessageRecipientId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailMessageId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EmailMessageRecipientTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessageRecipient", x => x.EmailMessageRecipientId);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessageRecipientType",
                schema: "messaging",
                columns: table => new
                {
                    EmailMessageRecipientTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessageRecipientTypeId", x => x.EmailMessageRecipientTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmailStatus",
                schema: "messaging",
                columns: table => new
                {
                    EmailStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_EmailStatus", x => x.EmailStatusId);
                });

            migrationBuilder.CreateTable(
                name: "EmailType",
                schema: "messaging",
                columns: table => new
                {
                    EmailTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsSwitchable = table.Column<bool>(type: "bit", nullable: false),
                    IsSwitchableByClient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailType", x => x.EmailTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentForm",
                schema: "common",
                columns: table => new
                {
                    EmploymentFormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_EmploymentForm", x => x.EmploymentFormId);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                schema: "indexing",
                columns: table => new
                {
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_Entity", x => new { x.EntityTypeId, x.EntityId });
                });

            migrationBuilder.CreateTable(
                name: "EntityAttribute",
                schema: "indexing",
                columns: table => new
                {
                    EntityAttributeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_EntityAttribute", x => x.EntityAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "EntityAttribute",
                schema: "mod",
                columns: table => new
                {
                    EntityAttributeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityAttributeBundleId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    IsValueReference = table.Column<bool>(type: "bit", nullable: false),
                    ValueEntityTypeId = table.Column<int>(type: "int", nullable: true),
                    ValueEntityObjectId = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsComplex = table.Column<bool>(type: "bit", nullable: false),
                    IsSystemSpecific = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_EntityAttribute", x => x.EntityAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "EntityAttributeBundle",
                schema: "mod",
                columns: table => new
                {
                    EntityAttributeBundleId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    SensitivityLevel = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_EntityAttributeBundle", x => x.EntityAttributeBundleId);
                });

            migrationBuilder.CreateTable(
                name: "EntityIndexTag",
                schema: "indexing",
                columns: table => new
                {
                    EntityIndexTagId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    EntityAttributeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IndexTagId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_EntityIndexTag", x => x.EntityIndexTagId);
                });

            migrationBuilder.CreateTable(
                name: "EntityNameI18n",
                schema: "common",
                columns: table => new
                {
                    I18nId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityObjectId = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    EntityObjectName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_EntityNameI18n", x => x.I18nId);
                });

            migrationBuilder.CreateTable(
                name: "EntityObject",
                schema: "meta",
                columns: table => new
                {
                    EntityObjectId = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    ObjectName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meta_EntityObject", x => x.EntityObjectId);
                });

            migrationBuilder.CreateTable(
                name: "EntityType",
                schema: "indexing",
                columns: table => new
                {
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_EntityType", x => x.EntityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EntityType",
                schema: "mod",
                columns: table => new
                {
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    HeadEntityTypeId = table.Column<int>(type: "int", nullable: false),
                    ParentEntityTypeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_EntityType", x => x.EntityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                schema: "mod",
                columns: table => new
                {
                    EventId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventSpaceId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                schema: "posting",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrlShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OnlineEventStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OnlinelEventEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OnsiteEventStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OnsiteEventEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    EventVenue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EventVenueLatitude = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    EventVenueLongtitude = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    Visitors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "EventParticipant",
                schema: "posting",
                columns: table => new
                {
                    EventParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    EventParticipationPackageId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifiedUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    EventCvDatabaseAccessStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventParticipant", x => x.EventParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "EventParticipationPackage",
                schema: "posting",
                columns: table => new
                {
                    EventParticipationPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoothTypeId = table.Column<int>(type: "int", nullable: false),
                    IsVideoAvailable = table.Column<bool>(type: "bit", nullable: false),
                    MaxAllowedNumber = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventParticipationPackage", x => x.EventParticipationPackageId);
                });

            migrationBuilder.CreateTable(
                name: "EventPartnerEducationalInstitution",
                schema: "posting",
                columns: table => new
                {
                    EventPartnerEducationalInstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalInstitutionId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPartnerEducationalInstitution", x => x.EventPartnerEducationalInstitutionId);
                });

            migrationBuilder.CreateTable(
                name: "EventSpace",
                schema: "mod",
                columns: table => new
                {
                    EventSpaceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_EventSpace", x => x.EventSpaceId);
                });

            migrationBuilder.CreateTable(
                name: "EventStatus",
                schema: "posting",
                columns: table => new
                {
                    EventStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStatus", x => x.EventStatusId);
                });

            migrationBuilder.CreateTable(
                name: "EventVisitor",
                schema: "posting",
                columns: table => new
                {
                    EventVisitorId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventVisitor", x => x.EventVisitorId);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                schema: "auth",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FeatureTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_Feature", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureType",
                schema: "auth",
                columns: table => new
                {
                    FeatureTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_FeatureType", x => x.FeatureTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GeneratedDocumentTemplate",
                schema: "client",
                columns: table => new
                {
                    GeneratedDocumentTemplateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratedDocumentTemplate", x => x.GeneratedDocumentTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "GeneratedDocumentTemplateContent",
                schema: "client",
                columns: table => new
                {
                    GeneratedDocumentTemplateContentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneratedDocumentTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Footer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratedDocumentTemplateContent", x => x.GeneratedDocumentTemplateContentId);
                });

            migrationBuilder.CreateTable(
                name: "GeneratedDocumentType",
                schema: "client",
                columns: table => new
                {
                    GeneratedDocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratedDocumentType", x => x.GeneratedDocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Handle",
                schema: "mod",
                columns: table => new
                {
                    HandleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<long>(type: "bigint", nullable: true),
                    ParentHandleId = table.Column<long>(type: "bigint", nullable: true),
                    MasterHandleId = table.Column<long>(type: "bigint", nullable: true),
                    HeadHandleId = table.Column<long>(type: "bigint", nullable: true),
                    HandleStatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    LockDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockUserId = table.Column<long>(type: "bigint", nullable: true),
                    BindDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_Handle", x => x.HandleId);
                });

            migrationBuilder.CreateTable(
                name: "HandleStatus",
                schema: "mod",
                columns: table => new
                {
                    HandleStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_HandleStatus", x => x.HandleStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                schema: "common",
                columns: table => new
                {
                    HolidayId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<int>(type: "int", nullable: false),
                    IsWeekend = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.HolidayId);
                });

            migrationBuilder.CreateTable(
                name: "IndexingStatus",
                schema: "indexing",
                columns: table => new
                {
                    IndexingStatusId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Indexing__E0F5E788908546FC", x => x.IndexingStatusId);
                });

            migrationBuilder.CreateTable(
                name: "IndexTag",
                schema: "indexing",
                columns: table => new
                {
                    IndexTagId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    ValueString = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueIntegerFrom = table.Column<long>(type: "bigint", nullable: true),
                    ValueIntegerTo = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "date", nullable: true),
                    ValueLength = table.Column<int>(type: "int", nullable: true),
                    HashCode = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_IndexTag", x => x.IndexTagId);
                });

            migrationBuilder.CreateTable(
                name: "IndexTag_Metric",
                schema: "indexing",
                columns: table => new
                {
                    IndexTagMetricId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexTagId = table.Column<long>(type: "bigint", nullable: false),
                    TagTrait = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Metric = table.Column<double>(type: "float", nullable: false),
                    IsMajorTrait = table.Column<bool>(type: "bit", nullable: false),
                    TraitLength = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_IndexTag_Metric", x => x.IndexTagMetricId);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                schema: "common",
                columns: table => new
                {
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LookupStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_Industry", x => x.IndustryId);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                schema: "billing",
                columns: table => new
                {
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerialNumber = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PayerCustomerAccountId = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VATAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    AccountingStatusId = table.Column<int>(type: "int", nullable: false),
                    InvoiceFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsMerged = table.Column<bool>(type: "bit", nullable: false),
                    MergeTargetInvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    ApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayOffDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastStatusChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastStatusChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false),
                    IsInvoiceFileSent = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceFileSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceAccountingStatus",
                schema: "billing",
                columns: table => new
                {
                    InvoiceAccountingStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceAccountingStatus", x => x.InvoiceAccountingStatusId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCoverage",
                schema: "billing",
                columns: table => new
                {
                    InvoiceCoverageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastAmountEditUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastAmountEditDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCoverage", x => x.InvoiceCoverageId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                schema: "billing",
                columns: table => new
                {
                    InvoiceStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_InvoiceStatus", x => x.InvoiceStatusId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceType",
                schema: "billing",
                columns: table => new
                {
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_InvoiceType", x => x.InvoiceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "store",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    ListPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                schema: "system",
                columns: table => new
                {
                    JobId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Priority = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_Job", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker",
                schema: "client",
                columns: table => new
                {
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocalityId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsCurrentlyEmployed = table.Column<bool>(type: "bit", nullable: true),
                    DesiredSalary = table.Column<int>(type: "int", nullable: true),
                    IsVehicleOwner = table.Column<bool>(type: "bit", nullable: false),
                    IsWillingToWorkAbroad = table.Column<bool>(type: "bit", nullable: true),
                    JobseekerProfileStateId = table.Column<int>(type: "int", nullable: false),
                    JobseekerPrivacyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InsertUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    DailyDigestOn = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkExperienceFilled = table.Column<bool>(type: "bit", nullable: false),
                    LastProfileStateCheckDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OriginWebsiteId = table.Column<int>(type: "int", nullable: false),
                    ExportedCvFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProfileFillDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MigratedFromOriginWebsiteId = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsInternalEmployee = table.Column<bool>(type: "bit", nullable: false),
                    LastFlagUnflagInternalEmployeeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastFlagUnflagInternalEmployeeUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    InactiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReactivateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalWorkExperienceInMonths = table.Column<int>(type: "int", nullable: false),
                    IndexingStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker", x => x.JobseekerId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_Attachment",
                schema: "client",
                columns: table => new
                {
                    JobseekerAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerDocumentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_Attachment", x => x.JobseekerAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_Document",
                schema: "client",
                columns: table => new
                {
                    JobseekerDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContentType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_Document", x => x.JobseekerDocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_DrivingLicence",
                schema: "client",
                columns: table => new
                {
                    JobseekerDrivingLicenceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    DrivingLicenceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_DrivingLicence", x => x.JobseekerDrivingLicenceId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_Education",
                schema: "client",
                columns: table => new
                {
                    JobseekerEducationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    EducationLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IgnoreDay = table.Column<bool>(type: "bit", nullable: true),
                    Institution = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobseekerFileId = table.Column<long>(type: "bigint", nullable: true),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: true),
                    DateFromYear = table.Column<int>(type: "int", nullable: false),
                    DateFromMonth = table.Column<int>(type: "int", nullable: true),
                    DateToYear = table.Column<int>(type: "int", nullable: false),
                    DateToMonth = table.Column<int>(type: "int", nullable: true),
                    EducationalInstitutionId = table.Column<int>(type: "int", nullable: true),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: true),
                    EducationalProgramName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_Education", x => x.JobseekerEducationId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_File",
                schema: "client",
                columns: table => new
                {
                    JobseekerFileId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    ContentType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_File", x => x.JobseekerFileId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_IgnoredCustomer",
                schema: "client",
                columns: table => new
                {
                    JobseekerIgnoredCustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_IgnoredCustomer", x => x.JobseekerIgnoredCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_Language",
                schema: "client",
                columns: table => new
                {
                    JobseekerLanguageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageProficiencyLevelId = table.Column<long>(type: "bigint", nullable: false),
                    WorldLanguageId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerFileId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_Language", x => x.JobseekerLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_LocalitySubscription",
                schema: "client",
                columns: table => new
                {
                    JobseekerLocalitySubscriptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobseeker_LocalitySubscription", x => x.JobseekerLocalitySubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_OccupationCategorySubscription",
                schema: "client",
                columns: table => new
                {
                    JobseekerOccupationCategorySubscriptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    OccupationCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_OccupationCategorySubscription", x => x.JobseekerOccupationCategorySubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_Photo",
                schema: "client",
                columns: table => new
                {
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_jobseeker_Photo", x => x.JobseekerId);
                });

            migrationBuilder.CreateTable(
                name: "Jobseeker_WorkExperience",
                schema: "client",
                columns: table => new
                {
                    JobseekerWorkExperienceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    DateFromYear = table.Column<int>(type: "int", nullable: false),
                    DateFromMonth = table.Column<int>(type: "int", nullable: true),
                    DateToYear = table.Column<int>(type: "int", nullable: true),
                    DateToMonth = table.Column<int>(type: "int", nullable: true),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PositionTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobseekerFileId = table.Column<long>(type: "bigint", nullable: true),
                    IsLast = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Jobseeker_WorkExperience", x => x.JobseekerWorkExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerDocumentContentPlainText",
                schema: "client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerDocumentId = table.Column<long>(type: "bigint", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PlainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobseekerDocumentContentPlainText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerDocumentType",
                schema: "client",
                columns: table => new
                {
                    JobseekerDocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_JobseekerDocumentType", x => x.JobseekerDocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerPrivacy",
                schema: "client",
                columns: table => new
                {
                    JobseekerPrivacyId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_JobseekerPrivacy", x => x.JobseekerPrivacyId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerProfileState",
                schema: "client",
                columns: table => new
                {
                    JobseekerProfileStateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_JobseekerProfileState", x => x.JobseekerProfileStateId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerStatus",
                schema: "client",
                columns: table => new
                {
                    JobseekerStatusId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_JobseekerStatus", x => x.JobseekerStatusId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerSubscriptionUpdateHistory",
                schema: "client",
                columns: table => new
                {
                    JobseekerSubscriptionUpdateHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobseekerSubscriptionUpdateHistory", x => x.JobseekerSubscriptionUpdateHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerWorkExperience_Category",
                schema: "client",
                columns: table => new
                {
                    JobseekerWorkExperienceCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerWorkExperienceId = table.Column<long>(type: "bigint", nullable: false),
                    OccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_JobseekerWorkExperience_Category", x => x.JobseekerWorkExperienceCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Keyword",
                schema: "indexing",
                columns: table => new
                {
                    KeywordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeywordText = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_Keyword", x => x.KeywordId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "common",
                columns: table => new
                {
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "ux",
                columns: table => new
                {
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    CultureName = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    NativeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortNativeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsUI = table.Column<bool>(type: "bit", nullable: false),
                    IsEntryData = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageCharset",
                schema: "messaging",
                columns: table => new
                {
                    LanguageCharsetId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCharset", x => x.LanguageCharsetId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageProficiencyLevel",
                schema: "common",
                columns: table => new
                {
                    LanguageProficiencyLevelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_LanguageProficiencyLevel", x => x.LanguageProficiencyLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Locality",
                schema: "common",
                columns: table => new
                {
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsCity = table.Column<bool>(type: "bit", nullable: false),
                    IsCapital = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IndexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_Locality", x => x.LocalityId);
                });

            migrationBuilder.CreateTable(
                name: "LogoStatus",
                schema: "common",
                columns: table => new
                {
                    LogoStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_LogoStatus", x => x.LogoStatusId);
                });

            migrationBuilder.CreateTable(
                name: "LookupStatus",
                schema: "common",
                columns: table => new
                {
                    LookupStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_LookupStatus", x => x.LookupStatusId);
                });

            migrationBuilder.CreateTable(
                name: "MigratedRegistrant_OccupationCategory",
                schema: "client",
                columns: table => new
                {
                    MigratedRegistrant_OccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    OccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigratedRegistrant_OccupationCategory_1", x => x.MigratedRegistrant_OccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Moderation",
                schema: "mod",
                columns: table => new
                {
                    ModerationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: true),
                    ContentId = table.Column<long>(type: "bigint", nullable: true),
                    ModerationStatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_Moderation", x => x.ModerationId);
                });

            migrationBuilder.CreateTable(
                name: "ModerationContext",
                schema: "mod",
                columns: table => new
                {
                    ModerationContextId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HandleId = table.Column<long>(type: "bigint", nullable: false),
                    RequestActionId = table.Column<int>(type: "int", nullable: false),
                    IsApproveBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsRejectBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsParentBound = table.Column<bool>(type: "bit", nullable: true),
                    HasPendingContent = table.Column<bool>(type: "bit", nullable: false),
                    IsDependency = table.Column<bool>(type: "bit", nullable: false),
                    HasExternalApproveBlock = table.Column<bool>(type: "bit", nullable: false),
                    ExternalApproveMessages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasExternalRejectBlock = table.Column<bool>(type: "bit", nullable: false),
                    ExternalRejectMessages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BlockingChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockingChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_ModerationContext", x => x.ModerationContextId);
                });

            migrationBuilder.CreateTable(
                name: "ModerationStatus",
                schema: "mod",
                columns: table => new
                {
                    ModerationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_ModerationStatus", x => x.ModerationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPlan",
                schema: "sales",
                columns: table => new
                {
                    MonthlyPlanId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<long>(type: "bigint", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    Holidays = table.Column<int>(type: "int", nullable: false),
                    WorkingDays = table.Column<int>(type: "int", nullable: false),
                    Saturdays = table.Column<int>(type: "int", nullable: false),
                    Payments = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Invoices = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    SharesPlan = table.Column<int>(type: "int", nullable: true),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsEditable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPlan", x => x.MonthlyPlanId);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPlanItem",
                schema: "sales",
                columns: table => new
                {
                    MonthlyPlanItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPlanId = table.Column<long>(type: "bigint", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    WebsiteId = table.Column<int>(type: "int", nullable: true),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPlanItem", x => x.MonthlyPlanItemId);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPlanProductType",
                schema: "sales",
                columns: table => new
                {
                    MonthlyPlanProductTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPlanId = table.Column<long>(type: "bigint", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    WebsiteId = table.Column<int>(type: "int", nullable: true),
                    TotalCount = table.Column<int>(type: "int", nullable: true),
                    SoldCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPlanProductType", x => x.MonthlyPlanProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                schema: "crm",
                columns: table => new
                {
                    NotificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    SubTypeId = table.Column<int>(type: "int", nullable: false),
                    TargetEntityTypeId = table.Column<int>(type: "int", nullable: false),
                    TargetEntityId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ProcessAttemptCount = table.Column<int>(type: "int", nullable: false),
                    MaxProcessAttemptCount = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ScheduledProcessDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActualProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsLast = table.Column<bool>(type: "bit", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationChannel",
                schema: "crm",
                columns: table => new
                {
                    NotificationChannelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationChannel", x => x.NotificationChannelId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationStatus",
                schema: "crm",
                columns: table => new
                {
                    NotificationStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationStatus", x => x.NotificationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationSubType",
                schema: "crm",
                columns: table => new
                {
                    NotificationSubTypeId = table.Column<int>(type: "int", nullable: false),
                    NotificationTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSubType", x => x.NotificationSubTypeId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTargetEntityType",
                schema: "crm",
                columns: table => new
                {
                    NotificationTargetEntityTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NotificationType",
                schema: "crm",
                columns: table => new
                {
                    NotificationTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationType", x => x.NotificationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectHashCode",
                schema: "system",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HashCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ObjectID = table.Column<int>(type: "int", nullable: false),
                    ObjectType = table.Column<short>(type: "smallint", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_EntityHashCode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OccupationCategory",
                schema: "common",
                columns: table => new
                {
                    OccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadOccupationCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    KeyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_OccupationCategory", x => x.OccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "store",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ShippingStatusId = table.Column<int>(type: "int", nullable: false),
                    ProFormaInvoiceFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPartialShippingAllowed = table.Column<bool>(type: "bit", nullable: true),
                    IsAutoGenerated = table.Column<bool>(type: "bit", nullable: false),
                    OriginalOrderId = table.Column<long>(type: "bigint", nullable: true),
                    CancelUserId = table.Column<long>(type: "bigint", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejectUserId = table.Column<long>(type: "bigint", nullable: true),
                    RejectDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PartialShippingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsStandalone = table.Column<bool>(type: "bit", nullable: false),
                    IsOverriden = table.Column<bool>(type: "bit", nullable: false),
                    RootOrderId = table.Column<long>(type: "bigint", nullable: true),
                    OverrideOrderId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Order_Item",
                schema: "store",
                columns: table => new
                {
                    OrderItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ItemNumber = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    IsDetailPending = table.Column<bool>(type: "bit", nullable: true),
                    DetailId = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsUpgrade = table.Column<bool>(type: "bit", nullable: false),
                    IsOverriden = table.Column<bool>(type: "bit", nullable: false),
                    OverrideOrderItemId = table.Column<long>(type: "bigint", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OriginalOrderItemId = table.Column<long>(type: "bigint", nullable: true),
                    IsOverridePending = table.Column<bool>(type: "bit", nullable: false),
                    UsedQuantityBeforeOverride = table.Column<int>(type: "int", nullable: true),
                    Customization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Order_Item", x => x.OrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "OrderShippingStatus",
                schema: "store",
                columns: table => new
                {
                    OrderShippingStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderShippingStatus", x => x.OrderShippingStatusId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                schema: "store",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "billing",
                columns: table => new
                {
                    PaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PayerAccountId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentChannelId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OriginalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AmountLeft = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifiedUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastAmountEditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastAmountEditUserId = table.Column<long>(type: "bigint", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentChannel",
                schema: "billing",
                columns: table => new
                {
                    PaymentChannelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_PaymentChannel", x => x.PaymentChannelId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                schema: "billing",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                schema: "billing",
                columns: table => new
                {
                    PaymentStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_PaymentStatus", x => x.PaymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                schema: "billing",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_PaymentType", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                schema: "client",
                columns: table => new
                {
                    PortfolioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.PortfolioId);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio_AccountManager",
                schema: "client",
                columns: table => new
                {
                    PortfolioAccountManagerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<long>(type: "bigint", nullable: false),
                    AccountManagerAdminId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsCurrent = table.Column<long>(type: "bigint", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio_AccountManager", x => x.PortfolioAccountManagerId);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio_Customer",
                schema: "client",
                columns: table => new
                {
                    PortfolioCustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PortfolioId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio_Customer", x => x.PortfolioCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "PostingChannel",
                schema: "comments",
                columns: table => new
                {
                    PostingChannelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostingChannel", x => x.PostingChannelId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "store",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsLegacy = table.Column<bool>(type: "bit", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Product_Aspect",
                schema: "store",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductAspectId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: true),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValueFloat = table.Column<double>(type: "float", nullable: true),
                    ValueComplex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Product_Aspect", x => new { x.ProductId, x.ProductAspectId });
                });

            migrationBuilder.CreateTable(
                name: "ProductAspect",
                schema: "store",
                columns: table => new
                {
                    ProductAspectId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    IsMulti = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_ProductAspect", x => x.ProductAspectId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCombinationConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductCombinationConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    IsStandalone = table.Column<bool>(type: "bit", nullable: false),
                    MaxAllowedItemCountPerOrder = table.Column<int>(type: "int", nullable: false),
                    DependencyProductGroupId = table.Column<int>(type: "int", nullable: true),
                    DependencyProductId = table.Column<int>(type: "int", nullable: true),
                    DependencyChannelId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCombinationConstraint", x => x.ProductCombinationConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroup",
                schema: "store",
                columns: table => new
                {
                    ProductGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.ProductGroupId);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroup_Product",
                schema: "store",
                columns: table => new
                {
                    ProducGroupProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup_Product", x => x.ProducGroupProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductIncompatibilityConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductIncompatibilityConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    IncompatibleProductGroupId = table.Column<int>(type: "int", nullable: true),
                    IncompatibleProductId = table.Column<int>(type: "int", nullable: true),
                    IncompatibleChannelId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIncompatibilityConstraint", x => x.ProductIncompatibilityConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "ProductReplacementConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductReplacementConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ReplacementProductId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReplacementConstraint", x => x.ProductReplacementConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                schema: "store",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsCore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeAvailabilityConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductTypeAvailabilityConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeAvailabilityConstraint", x => x.ProductTypeAvailabilityConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeCombinationConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductTypeCombinationConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoreProductTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryProductTypeId = table.Column<int>(type: "int", nullable: false),
                    IsAllowed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeCombinationConstraint", x => x.ProductTypeCombinationConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "ProductUpgradeConstraint",
                schema: "constraints",
                columns: table => new
                {
                    ProductUpgradeConstraintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalProductGroupId = table.Column<int>(type: "int", nullable: true),
                    OriginalProductId = table.Column<int>(type: "int", nullable: true),
                    OriginalProductChannelId = table.Column<int>(type: "int", nullable: true),
                    NewProductGroupId = table.Column<int>(type: "int", nullable: true),
                    NewProductId = table.Column<int>(type: "int", nullable: true),
                    NewProductChannelId = table.Column<int>(type: "int", nullable: true),
                    IsUpgradeDenied = table.Column<bool>(type: "bit", nullable: false),
                    IsAddDenied = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUpgradeConstraint", x => x.ProductUpgradeConstraintId);
                });

            migrationBuilder.CreateTable(
                name: "PromoEmail_Portfolio",
                schema: "messaging",
                columns: table => new
                {
                    PromoEmailPortfolioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoEmailTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    PortfolioId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoEmail_Portfolio", x => x.PromoEmailPortfolioId);
                });

            migrationBuilder.CreateTable(
                name: "PromoEmailAttachment",
                schema: "messaging",
                columns: table => new
                {
                    PromoEmailAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoEmailTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoEmailAttachment", x => x.PromoEmailAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "PromoEmailStatus",
                schema: "messaging",
                columns: table => new
                {
                    PromoEmailStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoEmailStatus", x => x.PromoEmailStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PromoEmailTemplate",
                schema: "messaging",
                columns: table => new
                {
                    PromoEmailTemplateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoEmailTemplate", x => x.PromoEmailTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "ProviderWebsite",
                schema: "system",
                columns: table => new
                {
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false),
                    IndexNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsExternal = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LogoFileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAnnouncementProvider = table.Column<bool>(type: "bit", nullable: false),
                    IsCvProvider = table.Column<bool>(type: "bit", nullable: false),
                    IsCategorized = table.Column<bool>(type: "bit", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    LaunchYear = table.Column<short>(type: "smallint", nullable: true),
                    IsCvBoxProvider = table.Column<bool>(type: "bit", nullable: false),
                    IsRegistrable = table.Column<bool>(type: "bit", nullable: false),
                    IsPreferred = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_ProviderWebsite", x => x.ProviderWebsiteId);
                });

            migrationBuilder.CreateTable(
                name: "ProviderWebsite_OccupationCategory",
                schema: "system",
                columns: table => new
                {
                    ProviderWebsiteOccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false),
                    OccupationCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderWebsite_OccupationCategory", x => x.ProviderWebsiteOccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Record",
                schema: "audit",
                columns: table => new
                {
                    RecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<long>(type: "bigint", nullable: false),
                    EntityObjectId = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    Attribute = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Context = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValueFloat = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audit_Record", x => x.RecordId);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                schema: "mod",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    HandleId = table.Column<long>(type: "bigint", nullable: false),
                    RequestActionId = table.Column<int>(type: "int", nullable: false),
                    ConceptRequestActionId = table.Column<int>(type: "int", nullable: false),
                    IsContentOverridable = table.Column<bool>(type: "bit", nullable: true),
                    IsFulfilled = table.Column<bool>(type: "bit", nullable: false),
                    ModerationId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    FulfilDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FulfilUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_Request", x => x.RequestId);
                });

            migrationBuilder.CreateTable(
                name: "RequestAction",
                schema: "mod",
                columns: table => new
                {
                    RequestActionId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mod_RequestAction", x => x.RequestActionId);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                schema: "ux",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceScopeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "ntext", nullable: false),
                    IsProviderWebsiteSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_Resource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceI18n",
                schema: "ux",
                columns: table => new
                {
                    ResourceI18nId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Value = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_ResourceI18n", x => x.ResourceI18nId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceScope",
                schema: "ux",
                columns: table => new
                {
                    ResourceScopeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_ResourceScope", x => x.ResourceScopeId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "auth",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsBasicRole = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RoleFeature",
                schema: "auth",
                columns: table => new
                {
                    RoleFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_RoleFeature", x => x.RoleFeatureId);
                });

            migrationBuilder.CreateTable(
                name: "SchemaVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Applied = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemaVersions_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                schema: "store",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsHost = table.Column<bool>(type: "bit", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    LogoUrl = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_Seller", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                schema: "auth",
                columns: table => new
                {
                    SessionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionUid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    UserDetailId = table.Column<long>(type: "bigint", nullable: true),
                    AssociatedUserTypeId = table.Column<int>(type: "int", nullable: true),
                    AssociatedUserDetailId = table.Column<long>(type: "bigint", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AbsoluteExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastAccessDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpirationSetDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsUserDataRefreshRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_Session", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                schema: "ux",
                columns: table => new
                {
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    SettingLevelId = table.Column<int>(type: "int", nullable: true),
                    MasterSettingId = table.Column<int>(type: "int", nullable: false),
                    ParentSettingId = table.Column<int>(type: "int", nullable: true),
                    KeyName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsValueItem = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    DataTypeId = table.Column<int>(type: "int", nullable: true),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValueFloat = table.Column<double>(type: "float", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsProviderWebsiteSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_Setting", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "SettingI18n",
                schema: "ux",
                columns: table => new
                {
                    SettingI18nId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_SettingI18n", x => x.SettingI18nId);
                });

            migrationBuilder.CreateTable(
                name: "SettingLevel",
                schema: "ux",
                columns: table => new
                {
                    SettingLevelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_SettingLevel", x => x.SettingLevelId);
                });

            migrationBuilder.CreateTable(
                name: "SliderBanner",
                schema: "client",
                columns: table => new
                {
                    SliderBannerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    RequestCustomerAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SliderBannerStatusId = table.Column<int>(type: "int", nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    ProcessUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderBanner", x => x.SliderBannerId);
                });

            migrationBuilder.CreateTable(
                name: "SliderBannerStatus",
                schema: "client",
                columns: table => new
                {
                    SliderBannerStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderBannerStatus", x => x.SliderBannerStatus);
                });

            migrationBuilder.CreateTable(
                name: "Sms_StopReason",
                schema: "messaging",
                columns: table => new
                {
                    SmsStopReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmsTypeId = table.Column<int>(type: "int", nullable: false),
                    StopReasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sms_StopReason", x => x.SmsStopReasonId);
                });

            migrationBuilder.CreateTable(
                name: "SmsMessage",
                schema: "messaging",
                columns: table => new
                {
                    SmsMessageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    SendAttemptCount = table.Column<int>(type: "int", nullable: false),
                    MaxSendAttemptCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsMessage", x => x.SmsMessageId);
                });

            migrationBuilder.CreateTable(
                name: "SmsStatus",
                schema: "messaging",
                columns: table => new
                {
                    SmsStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsStatus", x => x.SmsStatusId);
                });

            migrationBuilder.CreateTable(
                name: "SmsStopReason",
                schema: "messaging",
                columns: table => new
                {
                    SmsStopReasonId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsStopReason", x => x.SmsStopReasonId);
                });

            migrationBuilder.CreateTable(
                name: "SmsTemplate",
                schema: "messaging",
                columns: table => new
                {
                    SmsTemplateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsTemplate", x => x.SmsTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "SmsTemplateContent",
                schema: "messaging",
                columns: table => new
                {
                    SmsTemplateContentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmsTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageCharsetId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsTemplateContent", x => x.SmsTemplateContentId);
                });

            migrationBuilder.CreateTable(
                name: "SmsType",
                schema: "messaging",
                columns: table => new
                {
                    SmsTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    IsSwitchable = table.Column<bool>(type: "bit", nullable: false),
                    IsSwitchableByClient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsType", x => x.SmsTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialPriceOffer",
                schema: "store",
                columns: table => new
                {
                    SpecialPriceOfferId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
                    CustomerGroupId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialPriceOffer", x => x.SpecialPriceOfferId);
                });

            migrationBuilder.CreateTable(
                name: "StaticContent",
                schema: "ux",
                columns: table => new
                {
                    StaticContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleResouceId = table.Column<int>(type: "int", nullable: false),
                    ContentResouceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_StaticContent", x => x.StaticContentId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriber",
                schema: "client",
                columns: table => new
                {
                    SubscriberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubscriberStatusId = table.Column<int>(type: "int", nullable: false),
                    DailyDigestOn = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OriginWebsiteId = table.Column<int>(type: "int", nullable: false),
                    MigratedFromOriginWebsiteId = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    EmailVerificationResendToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailVerificationResendAttempts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Subscriber", x => x.SubscriberId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriber_LocalitySubscription",
                schema: "client",
                columns: table => new
                {
                    SubscriberLocalitySubscriptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<long>(type: "bigint", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriber_LocalitySubscription", x => x.SubscriberLocalitySubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriber_OccupationCategory",
                schema: "client",
                columns: table => new
                {
                    SubscriberOccupationCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<long>(type: "bigint", nullable: false),
                    OccupationCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_Subscriber_OccupationCategory", x => x.SubscriberOccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberStatus",
                schema: "client",
                columns: table => new
                {
                    SubscriberStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_SubscriberStatus", x => x.SubscriberStatusId);
                });

            migrationBuilder.CreateTable(
                name: "SuspendedEmailAddress",
                schema: "client",
                columns: table => new
                {
                    SuspendedEmailAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailDomain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false),
                    IsDomain = table.Column<bool>(type: "bit", nullable: false),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    SuspendType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BounceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BounceSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ComplaintType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuspendedEmailAddress", x => x.SuspendedEmailAddressId);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfig",
                schema: "system",
                columns: table => new
                {
                    SystemConfigId = table.Column<int>(type: "int", nullable: false),
                    MasterSystemConfigId = table.Column<int>(type: "int", nullable: false),
                    ParentSystemConfigId = table.Column<int>(type: "int", nullable: true),
                    KeyName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsValueItem = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    DataTypeId = table.Column<int>(type: "int", nullable: true),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValueFloat = table.Column<double>(type: "float", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsProviderWebsiteSpecific = table.Column<bool>(type: "bit", nullable: false),
                    ProviderWebsiteId = table.Column<int>(type: "int", nullable: true),
                    ValueObject = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_SystemConfig", x => x.SystemConfigId);
                });

            migrationBuilder.CreateTable(
                name: "TargetAudience",
                schema: "posting",
                columns: table => new
                {
                    TargetAudienceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting_TargetAudience", x => x.TargetAudienceId);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                schema: "messaging",
                columns: table => new
                {
                    TemplateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    EmaiTemplateGenerationPath = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Subject = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_Template", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "TemplateContent",
                schema: "messaging",
                columns: table => new
                {
                    TemplateContentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaging_TemplateContent", x => x.TemplateContentId);
                });

            migrationBuilder.CreateTable(
                name: "TermTag",
                schema: "indexing",
                columns: table => new
                {
                    TermTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_TermTag", x => x.TermTagId);
                });

            migrationBuilder.CreateTable(
                name: "TermTagRelation",
                schema: "indexing",
                columns: table => new
                {
                    TermTagRelationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermTagId = table.Column<int>(type: "int", nullable: false),
                    RelatedTermTagId = table.Column<int>(type: "int", nullable: false),
                    RelationWeight = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_TermTagRelation", x => x.TermTagRelationId);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                schema: "ux",
                columns: table => new
                {
                    ThemeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_Theme", x => x.ThemeId);
                });

            migrationBuilder.CreateTable(
                name: "Thread",
                schema: "comments",
                columns: table => new
                {
                    ThreadId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreadRelatedObjectTypeId = table.Column<int>(type: "int", nullable: false),
                    ThreadRelatedObjectId = table.Column<long>(type: "bigint", nullable: false),
                    ThreadTopicId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    IsAlive = table.Column<bool>(type: "bit", nullable: false),
                    LastPostDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thread", x => x.ThreadId);
                });

            migrationBuilder.CreateTable(
                name: "ThreadPost",
                schema: "comments",
                columns: table => new
                {
                    ThreadPostId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreadId = table.Column<long>(type: "bigint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostingChannelId = table.Column<int>(type: "int", nullable: false),
                    ReplyToPostId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadPost", x => x.ThreadPostId);
                });

            migrationBuilder.CreateTable(
                name: "ThreadRelatedObjectType",
                schema: "comments",
                columns: table => new
                {
                    ThreadRelatedObjectType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadRelatedObjectType", x => x.ThreadRelatedObjectType);
                });

            migrationBuilder.CreateTable(
                name: "ThreadTopic",
                schema: "comments",
                columns: table => new
                {
                    ThreadTopicId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadTopic", x => x.ThreadTopicId);
                });

            migrationBuilder.CreateTable(
                name: "Transaction_Invoice",
                schema: "billing",
                columns: table => new
                {
                    TransactionInvoiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionRecordId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction_Invoice", x => x.TransactionInvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionApprovalStatus",
                schema: "billing",
                columns: table => new
                {
                    TransactionApprovalStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionApprovalStatus", x => x.TransactionApprovalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRecord",
                schema: "billing",
                columns: table => new
                {
                    TransactionRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OriginalPayerAccountId = table.Column<long>(type: "bigint", nullable: false),
                    PayerAccountId = table.Column<long>(type: "bigint", nullable: false),
                    OriginalPaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    OriginalOrderId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    SalesCustomerPortfolioAccountManagerId = table.Column<long>(type: "bigint", nullable: true),
                    OriginalProFormaInvoiceFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProFormaInvoiceFileId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InitialPartialApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    InitialPartialApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InitialCompleteApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    InitialCompleteApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FinalApproveUserId = table.Column<long>(type: "bigint", nullable: true),
                    FinalApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderTotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TaxesTotalAmount = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IsTaxFree = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceTotalAmount = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ApprovalStatusId = table.Column<int>(type: "int", nullable: false),
                    TransactionStatusId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastOrderEditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastOrderEditUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastOrderTotalAmountWithDiscountEditUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastOrderTotalAmountWithDiscountEditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPayerEditUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastPayerEditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    IsProFormaInvoiceSent = table.Column<bool>(type: "bit", nullable: false),
                    ProFormaInvoiceSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProFormaInvoiceSendUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastSendProformaInvoiceFileId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderTotalAmountWithDiscount = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CancelUserId = table.Column<long>(type: "bigint", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejectUserId = table.Column<long>(type: "bigint", nullable: true),
                    RejectDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReverseUserId = table.Column<long>(type: "bigint", nullable: true),
                    ReverseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    IsConfirmationEmailSent = table.Column<bool>(type: "bit", nullable: true),
                    ConfirmationEmailSendDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecord", x => x.TransactionRecordId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatus",
                schema: "billing",
                columns: table => new
                {
                    TransactionStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatus", x => x.TransactionStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                schema: "common",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    UserStatusId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsPasswordChangeRequired = table.Column<bool>(type: "bit", nullable: false),
                    LastVisitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OriginWebsiteId = table.Column<int>(type: "int", nullable: true),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    MigratedFromOriginWebsiteId = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true),
                    EmailVerificationResendToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailVerificationResendAttempts = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserFeature",
                schema: "auth",
                columns: table => new
                {
                    UserFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_UserFeature", x => x.UserFeatureId);
                });

            migrationBuilder.CreateTable(
                name: "UserPreference",
                schema: "ux",
                columns: table => new
                {
                    UserPreferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueInteger = table.Column<long>(type: "bigint", nullable: true),
                    ValueBool = table.Column<bool>(type: "bit", nullable: true),
                    ValueDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ux_UserPreference", x => x.UserPreferenceId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "auth",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "UserSmsLanguageCharset",
                schema: "messaging",
                columns: table => new
                {
                    UserSmsLanguageCharsetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    SmsTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageCharsetId = table.Column<int>(type: "int", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSmsLanguageCharset", x => x.UserSmsLanguageCharsetId);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                schema: "common",
                columns: table => new
                {
                    UserStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_UserStatus", x => x.UserStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserStoppedEmail",
                schema: "messaging",
                columns: table => new
                {
                    UserStoppedEmailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    EmailTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStoppedEmail", x => x.UserStoppedEmailId);
                });

            migrationBuilder.CreateTable(
                name: "UserStoppedSms",
                schema: "messaging",
                columns: table => new
                {
                    UserStoppedSmsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    SmsTypeId = table.Column<int>(type: "int", nullable: false),
                    StopReasonId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStoppedSms", x => x.UserStoppedSmsId);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                schema: "common",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_UserType", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VATStatus",
                schema: "billing",
                columns: table => new
                {
                    VATStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing_VATStatus", x => x.VATStatusId);
                });

            migrationBuilder.CreateTable(
                name: "WorldLanguage",
                schema: "common",
                columns: table => new
                {
                    WorldLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChangeUserId = table.Column<long>(type: "bigint", nullable: true),
                    IndexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_common_WorldLanguage", x => x.WorldLanguageId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_posting.Announcement_CustomerId",
                schema: "posting",
                table: "Announcement",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_EntityAttributeId",
                schema: "mod",
                table: "Content",
                column: "EntityAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_RequestId",
                schema: "mod",
                table: "Content",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_mod_Content_IsProcessed_inc_RequestId",
                schema: "mod",
                table: "Content",
                column: "IsProcessed");

            migrationBuilder.CreateIndex(
                name: "Customer_IdNumber_Unique",
                schema: "client",
                table: "Customer",
                column: "IdNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_client_CustomerAgent_UserId",
                schema: "client",
                table: "CustomerAgent",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachment_EmailMessageId",
                schema: "messaging",
                table: "EmailAttachment",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessage_EmailStatusId",
                schema: "messaging",
                table: "EmailMessage",
                column: "EmailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessage_EmailStatusId_IsDeleted_PlannedSendDate",
                schema: "messaging",
                table: "EmailMessage",
                columns: new[] { "EmailStatusId", "IsDeleted", "PlannedSendDate" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessageRecipient_EmailMessageId",
                schema: "messaging",
                table: "EmailMessageRecipient",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_indexing_Entity_EntityTypeId",
                schema: "indexing",
                table: "Entity",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityIndexTag_EntityAttributeId",
                schema: "indexing",
                table: "EntityIndexTag",
                column: "EntityAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityIndexTag_EntityId",
                schema: "indexing",
                table: "EntityIndexTag",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityIndexTag_EntityTypeId",
                schema: "indexing",
                table: "EntityIndexTag",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityIndexTag_EntityTypeId_EntityAttributeId",
                schema: "indexing",
                table: "EntityIndexTag",
                columns: new[] { "EntityTypeId", "EntityAttributeId" });

            migrationBuilder.CreateIndex(
                name: "IX_EntityIndexTag_IndexTagId",
                schema: "indexing",
                table: "EntityIndexTag",
                column: "IndexTagId");

            migrationBuilder.CreateIndex(
                name: "IX_common_EntityNameI18n_EntityObjectId_EntityId_LanguageId_unique",
                schema: "common",
                table: "EntityNameI18n",
                columns: new[] { "EntityObjectId", "EntityId", "LanguageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Handle_EntityTypeId_EntityId",
                schema: "mod",
                table: "Handle",
                columns: new[] { "EntityTypeId", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_Handle_HeadHandleId",
                schema: "mod",
                table: "Handle",
                column: "HeadHandleId");

            migrationBuilder.CreateIndex(
                name: "IX_Handle_ParentHandleId",
                schema: "mod",
                table: "Handle",
                column: "ParentHandleId");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTag",
                schema: "indexing",
                table: "IndexTag",
                column: "HashCode");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTag_ValueBool",
                schema: "indexing",
                table: "IndexTag",
                column: "ValueBool");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTag_ValueDate",
                schema: "indexing",
                table: "IndexTag",
                column: "ValueDate");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTag_ValueInteger",
                schema: "indexing",
                table: "IndexTag",
                column: "ValueInteger");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTag_ValueString",
                schema: "indexing",
                table: "IndexTag",
                column: "ValueString");

            migrationBuilder.CreateIndex(
                name: "IX_indexing_IndexTagMetric_TagTrait_inc_IndexTagId_Metric",
                schema: "indexing",
                table: "IndexTag_Metric",
                column: "TagTrait");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTagMetric_IndexTagId",
                schema: "indexing",
                table: "IndexTag_Metric",
                column: "IndexTagId");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTagMetric_IndexTagId_inc_Metric_TagTrait",
                schema: "indexing",
                table: "IndexTag_Metric",
                column: "IndexTagId");

            migrationBuilder.CreateIndex(
                name: "IX_IndexTagMetric_TagTrait",
                schema: "indexing",
                table: "IndexTag_Metric",
                column: "TagTrait");

            migrationBuilder.CreateIndex(
                name: "IX_Job_Status",
                schema: "system",
                table: "Job",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Jobseeker_IndexingStatusId",
                schema: "client",
                table: "Jobseeker",
                column: "IndexingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobseeker_UserId",
                schema: "client",
                table: "Jobseeker",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerDrivingLicense_DrivingLicenseId_inc_JobseekerId",
                schema: "client",
                table: "Jobseeker_DrivingLicence",
                column: "DrivingLicenceId");

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerDrivingLicense_JobseekerId_DrivingLicenseId",
                schema: "client",
                table: "Jobseeker_DrivingLicence",
                columns: new[] { "JobseekerId", "DrivingLicenceId" });

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerEducation_EducationLevelId_inc_JobseekerId",
                schema: "client",
                table: "Jobseeker_Education",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerEducation_JobseekerId_EducationLevelId",
                schema: "client",
                table: "Jobseeker_Education",
                columns: new[] { "JobseekerId", "EducationLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerLanguage_JobseekerId_WorldLanguageId",
                schema: "client",
                table: "Jobseeker_Language",
                columns: new[] { "JobseekerId", "WorldLanguageId" });

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerLanguage_WorldLanguageId_inc_JobseekerId",
                schema: "client",
                table: "Jobseeker_Language",
                column: "WorldLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerWorkExperience_JobseekerId",
                schema: "client",
                table: "Jobseeker_WorkExperience",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_jobseekerWorkExperienceCategory_OccupationCategoryId_inc_JobseekerWorkExperienceId",
                schema: "client",
                table: "JobseekerWorkExperience_Category",
                column: "OccupationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MigratedRegistrantOccupationCategory_JobseekerId_OccupationCategoryId",
                schema: "client",
                table: "MigratedRegistrant_OccupationCategory",
                columns: new[] { "JobseekerId", "OccupationCategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_ModerationContext_HandleId",
                schema: "mod",
                table: "ModerationContext",
                column: "HandleId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_HandleId",
                schema: "mod",
                table: "Request",
                column: "HandleId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_IsFulfilled",
                schema: "mod",
                table: "Request",
                column: "IsFulfilled");

            migrationBuilder.CreateIndex(
                name: "UN_ResourceScopeId_Name_ProviderWebsiteId",
                schema: "ux",
                table: "Resource",
                columns: new[] { "ResourceScopeId", "Name", "ProviderWebsiteId" },
                unique: true,
                filter: "[ProviderWebsiteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SuspendedEmailAddress_EmailAddress_IsSuspended_IsDomain_IsProcessed",
                schema: "client",
                table: "SuspendedEmailAddress",
                columns: new[] { "EmailAddress", "IsSuspended", "IsDomain", "IsProcessed" });

            migrationBuilder.CreateIndex(
                name: "DataCompareKey_Unique",
                schema: "system",
                table: "SystemConfig",
                columns: new[] { "KeyName", "IsProviderWebsiteSpecific", "ProviderWebsiteId" });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "common",
                table: "UserAccount",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Username_CustomerAgent_Admin_Unique",
                schema: "common",
                table: "UserAccount",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Username_Jobseeker_Unique",
                schema: "common",
                table: "UserAccount",
                columns: new[] { "Username", "OriginWebsiteId" },
                unique: true,
                filter: "[OriginWebsiteId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "AccountStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "Action",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "Admin",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Announcement",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_ApplicationDetail",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Attachment",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_DistributionChannel",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_DrivingLicence",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Language",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Locality",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Location",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Logo",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_MatchingList",
                schema: "matching");

            migrationBuilder.DropTable(
                name: "Announcement_OccupationCategory",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Announcement_Stat",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementBaubleType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementDecorationType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementFeed",
                schema: "feeds");

            migrationBuilder.DropTable(
                name: "AnnouncementFeedMatch",
                schema: "feeds");

            migrationBuilder.DropTable(
                name: "AnnouncementFeedMatchStatus",
                schema: "feeds");

            migrationBuilder.DropTable(
                name: "AnnouncementFrameType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementJobseekerApplication",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementListingSection",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementMatchingJobseeker",
                schema: "matching");

            migrationBuilder.DropTable(
                name: "AnnouncementMatchingJobseekerStatus",
                schema: "matching");

            migrationBuilder.DropTable(
                name: "AnnouncementMatchingListApprovalStatus",
                schema: "matching");

            migrationBuilder.DropTable(
                name: "AnnouncementMatchingListGenerationStatus",
                schema: "matching");

            migrationBuilder.DropTable(
                name: "AnnouncementModule",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementPublishStatus",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementRenewal",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementRenewal_Stat",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementSite",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementStatus",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "AnnouncementTypeSecondaryProductConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "AnnouncementWorkExperienceType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "ApplicationMethod",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "ApplicationStatus",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Bank",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "Banner",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerClickEvent",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerPosition",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerStatus",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerTarget",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerType",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BannerViewEvent",
                schema: "ads");

            migrationBuilder.DropTable(
                name: "BasePlacementSectionSecondaryProductConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "BoothType",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "BrandingAnnouncementTileType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Content",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "ContentAction",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Customer_Group",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Customer_IgnoredCustomer",
                schema: "feeds");

            migrationBuilder.DropTable(
                name: "CustomerAgent",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerAgentStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerAutomaticEmail",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerAutomaticSms",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerBranding",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerBrandingAccessToken",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerBrandingAccessTokenStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerBrandingType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerContract",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerContractType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerGroup",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerJobseekerView",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerJobseekerViewEvent",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerJobseekerViewEventSource",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerLocation",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerLogo",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerSavedJobseeker",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerSavedJobseekerFolder",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CustomerTypeBasePlacementSectionConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "CustomerTypeProductConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "CvBox",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvBoxAccessToken",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvBoxAccessTokenStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvBoxItem",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvBoxItemStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvBoxPageSection",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessProductGroup",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessProductGroup",
                schema: "store");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessToken",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessToken_CvDatabaseProvider",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessToken_Event",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessTokenRequest",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessTokenRequestStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessTokenStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "CvDatabaseAccessTokenType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "DataType",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "DeliveryFailure",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "DrivingLicence",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EducationalInstitution",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EducationalInstitutionType",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EducationalProgram",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EducationLevel",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EmailAttachment",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailContent",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailMessage",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailMessageRecipient",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailMessageRecipientType",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailStatus",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmailType",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "EmploymentForm",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Entity",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "EntityAttribute",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "EntityAttribute",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "EntityAttributeBundle",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "EntityIndexTag",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "EntityNameI18n",
                schema: "common");

            migrationBuilder.DropTable(
                name: "EntityObject",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "EntityType",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "EntityType",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "Event",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "Event",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "EventParticipant",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "EventParticipationPackage",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "EventPartnerEducationalInstitution",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "EventSpace",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "EventStatus",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "EventVisitor",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Feature",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "FeatureType",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "GeneratedDocumentTemplate",
                schema: "client");

            migrationBuilder.DropTable(
                name: "GeneratedDocumentTemplateContent",
                schema: "client");

            migrationBuilder.DropTable(
                name: "GeneratedDocumentType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Handle",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "HandleStatus",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "Holiday",
                schema: "common");

            migrationBuilder.DropTable(
                name: "IndexingStatus",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "IndexTag",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "IndexTag_Metric",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "Industry",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Invoice",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "InvoiceAccountingStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "InvoiceCoverage",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "InvoiceStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "InvoiceType",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "Item",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "system");

            migrationBuilder.DropTable(
                name: "Jobseeker",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_Attachment",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_Document",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_DrivingLicence",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_Education",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_File",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_IgnoredCustomer",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_Language",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_LocalitySubscription",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_OccupationCategorySubscription",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_Photo",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Jobseeker_WorkExperience",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerDocumentContentPlainText",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerDocumentType",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerPrivacy",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerProfileState",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerSubscriptionUpdateHistory",
                schema: "client");

            migrationBuilder.DropTable(
                name: "JobseekerWorkExperience_Category",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Keyword",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "LanguageCharset",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "LanguageProficiencyLevel",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Locality",
                schema: "common");

            migrationBuilder.DropTable(
                name: "LogoStatus",
                schema: "common");

            migrationBuilder.DropTable(
                name: "LookupStatus",
                schema: "common");

            migrationBuilder.DropTable(
                name: "MigratedRegistrant_OccupationCategory",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Moderation",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "ModerationContext",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "ModerationStatus",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "MonthlyPlan",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "MonthlyPlanItem",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "MonthlyPlanProductType",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Notification",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "NotificationChannel",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "NotificationStatus",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "NotificationSubType",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "NotificationTargetEntityType",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "NotificationType",
                schema: "crm");

            migrationBuilder.DropTable(
                name: "ObjectHashCode",
                schema: "system");

            migrationBuilder.DropTable(
                name: "OccupationCategory",
                schema: "common");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Order_Item",
                schema: "store");

            migrationBuilder.DropTable(
                name: "OrderShippingStatus",
                schema: "store");

            migrationBuilder.DropTable(
                name: "OrderStatus",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "PaymentChannel",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "PaymentMethod",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "PaymentStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "PaymentType",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "Portfolio",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Portfolio_AccountManager",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Portfolio_Customer",
                schema: "client");

            migrationBuilder.DropTable(
                name: "PostingChannel",
                schema: "comments");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Product_Aspect",
                schema: "store");

            migrationBuilder.DropTable(
                name: "ProductAspect",
                schema: "store");

            migrationBuilder.DropTable(
                name: "ProductCombinationConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "ProductGroup",
                schema: "store");

            migrationBuilder.DropTable(
                name: "ProductGroup_Product",
                schema: "store");

            migrationBuilder.DropTable(
                name: "ProductIncompatibilityConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "ProductReplacementConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "ProductType",
                schema: "store");

            migrationBuilder.DropTable(
                name: "ProductTypeAvailabilityConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "ProductTypeCombinationConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "ProductUpgradeConstraint",
                schema: "constraints");

            migrationBuilder.DropTable(
                name: "PromoEmail_Portfolio",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "PromoEmailAttachment",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "PromoEmailStatus",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "PromoEmailTemplate",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "ProviderWebsite",
                schema: "system");

            migrationBuilder.DropTable(
                name: "ProviderWebsite_OccupationCategory",
                schema: "system");

            migrationBuilder.DropTable(
                name: "Record",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "Request",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "RequestAction",
                schema: "mod");

            migrationBuilder.DropTable(
                name: "Resource",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "ResourceI18n",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "ResourceScope",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "RoleFeature",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "SchemaVersions");

            migrationBuilder.DropTable(
                name: "Seller",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Session",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "Setting",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "SettingI18n",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "SettingLevel",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "SliderBanner",
                schema: "client");

            migrationBuilder.DropTable(
                name: "SliderBannerStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Sms_StopReason",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsMessage",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsStatus",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsStopReason",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsTemplate",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsTemplateContent",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SmsType",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "SpecialPriceOffer",
                schema: "store");

            migrationBuilder.DropTable(
                name: "StaticContent",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "Subscriber",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Subscriber_LocalitySubscription",
                schema: "client");

            migrationBuilder.DropTable(
                name: "Subscriber_OccupationCategory",
                schema: "client");

            migrationBuilder.DropTable(
                name: "SubscriberStatus",
                schema: "client");

            migrationBuilder.DropTable(
                name: "SuspendedEmailAddress",
                schema: "client");

            migrationBuilder.DropTable(
                name: "SystemConfig",
                schema: "system");

            migrationBuilder.DropTable(
                name: "TargetAudience",
                schema: "posting");

            migrationBuilder.DropTable(
                name: "Template",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "TemplateContent",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "TermTag",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "TermTagRelation",
                schema: "indexing");

            migrationBuilder.DropTable(
                name: "Theme",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "Thread",
                schema: "comments");

            migrationBuilder.DropTable(
                name: "ThreadPost",
                schema: "comments");

            migrationBuilder.DropTable(
                name: "ThreadRelatedObjectType",
                schema: "comments");

            migrationBuilder.DropTable(
                name: "ThreadTopic",
                schema: "comments");

            migrationBuilder.DropTable(
                name: "Transaction_Invoice",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "TransactionApprovalStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "TransactionRecord",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "TransactionStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "UserAccount",
                schema: "common");

            migrationBuilder.DropTable(
                name: "UserFeature",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserPreference",
                schema: "ux");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserSmsLanguageCharset",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "UserStatus",
                schema: "common");

            migrationBuilder.DropTable(
                name: "UserStoppedEmail",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "UserStoppedSms",
                schema: "messaging");

            migrationBuilder.DropTable(
                name: "UserType",
                schema: "common");

            migrationBuilder.DropTable(
                name: "VATStatus",
                schema: "billing");

            migrationBuilder.DropTable(
                name: "WorldLanguage",
                schema: "common");
        }
    }
}
