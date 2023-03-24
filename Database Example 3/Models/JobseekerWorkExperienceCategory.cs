using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerWorkExperienceCategory
{
    public long JobseekerWorkExperienceCategoryId { get; set; }

    public long JobseekerWorkExperienceId { get; set; }

    public int OccupationCategoryId { get; set; }
}
