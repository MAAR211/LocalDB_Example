using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementMatchingListGenerationStatus
{
    public int AnnouncementMatchingListGenerationStatusId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
}
