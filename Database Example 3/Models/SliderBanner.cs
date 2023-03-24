using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SliderBanner
{
    public long SliderBannerId { get; set; }

    public long CustomerId { get; set; }

    public long RequestCustomerAgentId { get; set; }

    public DateTime CreateDate { get; set; }

    public int SliderBannerStatusId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public DateTime? ExpireDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public int DayCount { get; set; }

    public long? ProcessUserId { get; set; }

    public int ProviderWebsiteId { get; set; }
}
