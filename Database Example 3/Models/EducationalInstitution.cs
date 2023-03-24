using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EducationalInstitution
{
    public int EducationalInstitutionId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? NameLatin { get; set; }

    public string? LogoFilename { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsActive { get; set; }

    public int EducationalInstitutionTypeId { get; set; }
}
