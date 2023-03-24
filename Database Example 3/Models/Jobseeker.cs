using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Jobseeker
{
    public long JobseekerId { get; set; }

    public long UserId { get; set; }

    public int JobseekerStatusId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public byte? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? LocalityId { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumber2 { get; set; }

    public bool? IsCurrentlyEmployed { get; set; }

    public int? DesiredSalary { get; set; }

    public bool IsVehicleOwner { get; set; }

    public bool? IsWillingToWorkAbroad { get; set; }

    public int JobseekerProfileStateId { get; set; }

    public int JobseekerPrivacyId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime InsertDate { get; set; }

    public long InsertUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public bool DailyDigestOn { get; set; }

    public bool IsWorkExperienceFilled { get; set; }

    public DateTime? LastProfileStateCheckDate { get; set; }

    public int OriginWebsiteId { get; set; }

    public string? ExportedCvFileId { get; set; }

    public DateTime? ProfileFillDate { get; set; }

    public int? MigratedFromOriginWebsiteId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public bool IsInternalEmployee { get; set; }

    public DateTime? LastFlagUnflagInternalEmployeeDate { get; set; }

    public long? LastFlagUnflagInternalEmployeeUserId { get; set; }

    public long? DeleteUserId { get; set; }

    public DateTime? InactiveDate { get; set; }

    public DateTime? ReactivateDate { get; set; }

    public int TotalWorkExperienceInMonths { get; set; }

    public int IndexingStatusId { get; set; }
}
