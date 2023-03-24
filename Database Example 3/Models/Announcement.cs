using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Announcement
{
    public long AnnouncementId { get; set; }

    public long CustomerId { get; set; }

    public int AnnouncementStatusId { get; set; }

    public int AnnouncementTypeId { get; set; }

    public int? AnnouncementModuleId { get; set; }

    public bool? IsPriority { get; set; }

    public DateTime? PriorityUpdateDate { get; set; }

    public bool? IsArchived { get; set; }

    public string? Title { get; set; }

    public string? Title2 { get; set; }

    public string? Description { get; set; }

    public string? Description2 { get; set; }

    public bool IsWithLogo { get; set; }

    public bool IsAnonymous { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerName2 { get; set; }

    public int ApplicationMethodId { get; set; }

    public DateTime PublishDate { get; set; }

    public DateTime DeadlineDate { get; set; }

    public long? ContactCustomerAgentId { get; set; }

    public int? TargetAudienceId { get; set; }

    public int? EmploymentFormId { get; set; }

    public bool? IsTravelRequired { get; set; }

    public int? SalaryFrom { get; set; }

    public int? SalaryTo { get; set; }

    public int? DurationFrom { get; set; }

    public int? DurationTo { get; set; }

    public int? WorkExperienceFrom { get; set; }

    public int? WorkExperienceTo { get; set; }

    public int? EducationLevelId { get; set; }

    public bool? HideSalary { get; set; }

    public bool HideContactPerson { get; set; }

    public bool HideLocationExceptCity { get; set; }

    public DateTime InsertDate { get; set; }

    public long InsertUserId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public int? AnnouncementListingSectionId { get; set; }

    public int PublishStatusId { get; set; }

    public DateTime? RenewalDate { get; set; }

    public bool IsWithFrame { get; set; }

    public bool IsWithNewYearBauble { get; set; }

    public bool IsWithNewYearDecoration { get; set; }

    public int? FrameTypeId { get; set; }

    public int? BaubleTypeId { get; set; }

    public int? NewYearDecorationTypeId { get; set; }

    public bool IsFacebookShareOn { get; set; }

    public bool IsLinkedInShareOn { get; set; }

    public long? LastRenewalId { get; set; }

    public bool? IsEventSpecific { get; set; }

    public int? EventId { get; set; }

    public string DescriptionPlainText { get; set; } = null!;

    public string? Description2PlainText { get; set; }

    public bool IsWithBonus { get; set; }

    public bool IsInstagramShareOn { get; set; }

    public bool IsMatchingEligible { get; set; }

    public bool IsMatchingReady { get; set; }

    public bool IsSuitableForStudent { get; set; }

    public bool IsWorkFromHome { get; set; }

    public int? Bonus { get; set; }

    public int? WorkExperienceType { get; set; }
}
