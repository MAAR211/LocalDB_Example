using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementRenewal
{
    public long AnnouncementRenewalId { get; set; }

    public long AnnouncementId { get; set; }

    public DateTime? ScheduledRenewalDate { get; set; }

    public DateTime? ActualRenewalDate { get; set; }

    public int StatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateUserId { get; set; }

    public bool IsInstant { get; set; }
}
