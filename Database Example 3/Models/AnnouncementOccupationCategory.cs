using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementOccupationCategory
{
    public long AnnouncementOccupationCategoryId { get; set; }

    public long AnnouncementId { get; set; }

    public long OccupationCategoryId { get; set; }
}
