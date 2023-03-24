using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementJobseekerApplication
{
    public long AnnouncementJobseekerApplicationId { get; set; }

    public long AnnouncementId { get; set; }

    public long JobseekerId { get; set; }

    public int ApplicationStatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public DateTime? LastViewDate { get; set; }

    public int ProviderWebsiteId { get; set; }
}
