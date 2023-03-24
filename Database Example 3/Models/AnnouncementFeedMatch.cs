using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementFeedMatch
{
    public long AnnouncementFeedMatchId { get; set; }

    public long AnnouncementFeedId { get; set; }

    public long AnnouncementId { get; set; }

    public int StatusId { get; set; }
}
