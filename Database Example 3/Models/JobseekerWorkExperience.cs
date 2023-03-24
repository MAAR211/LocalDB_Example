using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerWorkExperience
{
    public long JobseekerWorkExperienceId { get; set; }

    public long JobseekerId { get; set; }

    public int DateFromYear { get; set; }

    public int? DateFromMonth { get; set; }

    public int? DateToYear { get; set; }

    public int? DateToMonth { get; set; }

    public bool IsCurrent { get; set; }

    public string Employer { get; set; } = null!;

    public string PositionTitle { get; set; } = null!;

    public string? Description { get; set; }

    public long? JobseekerFileId { get; set; }

    public bool? IsLast { get; set; }

    public DateTime? CreateDate { get; set; }
}
