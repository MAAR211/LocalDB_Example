using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerEducation
{
    public long JobseekerEducationId { get; set; }

    public long JobseekerId { get; set; }

    public long EducationLevelId { get; set; }

    public bool? IgnoreDay { get; set; }

    public string Institution { get; set; } = null!;

    public string? Specialization { get; set; }

    public string? Description { get; set; }

    public long? JobseekerFileId { get; set; }

    public bool? IsCurrent { get; set; }

    public int DateFromYear { get; set; }

    public int? DateFromMonth { get; set; }

    public int DateToYear { get; set; }

    public int? DateToMonth { get; set; }

    public int? EducationalInstitutionId { get; set; }

    public int? EducationalProgramId { get; set; }

    public string? EducationalProgramName { get; set; }

    public DateTime? CreateDate { get; set; }
}
