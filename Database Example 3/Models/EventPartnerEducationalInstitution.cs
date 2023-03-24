using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EventPartnerEducationalInstitution
{
    public int EventPartnerEducationalInstitutionId { get; set; }

    public int EducationalInstitutionId { get; set; }

    public int EventId { get; set; }

    public bool IsActive { get; set; }
}
