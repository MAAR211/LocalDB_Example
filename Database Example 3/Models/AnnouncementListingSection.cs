using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementListingSection
{
    public int AnnouncementListingSectionId { get; set; }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }
}
