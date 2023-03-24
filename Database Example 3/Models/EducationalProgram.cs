using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EducationalProgram
{
    public int EducationalProgramId { get; set; }

    public int EducationalInstitutionId { get; set; }

    public string? EducationalInstitutionCode { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string NameLatin { get; set; } = null!;

    public int EducationLevelId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsActive { get; set; }

    public string NameShort { get; set; } = null!;
}
