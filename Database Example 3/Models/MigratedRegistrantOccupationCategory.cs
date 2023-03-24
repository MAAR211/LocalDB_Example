using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class MigratedRegistrantOccupationCategory
{
    public int MigratedRegistrantOccupationCategoryId { get; set; }

    public long JobseekerId { get; set; }

    public int OccupationCategoryId { get; set; }
}
