using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementFeed
{
    public long AnnouncementFeedId { get; set; }

    public long CustomerId { get; set; }

    public string Title { get; set; } = null!;

    public bool HasModeration { get; set; }

    public string FilterObject { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
