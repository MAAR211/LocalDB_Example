using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementRenewalStat
{
    public long AnnouncementRenewalStatId { get; set; }

    public long AnnouncementRenewalId { get; set; }

    public int? TotalViewCount { get; set; }

    public int AnonymousViewCount { get; set; }

    public int NonAnonymousViewCount { get; set; }

    public int ProviderWebsiteId { get; set; }
}
