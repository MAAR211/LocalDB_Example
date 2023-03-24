using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementDistributionChannel
{
    public long AnnouncementDistributionChannelId { get; set; }

    public long AnnouncementId { get; set; }

    public int DistributionChannelId { get; set; }

    public DateTime CreateDate { get; set; }

    public int AnnouncementListingSectionId { get; set; }

    public bool IsPriority { get; set; }

    public DateTime? PriorityUpdateDate { get; set; }

    public bool IsWithLogo { get; set; }

    public bool IsWithFrame { get; set; }

    public bool IsWithNewYearBauble { get; set; }

    public bool IsWithNewYearDecoration { get; set; }

    public int? FrameTypeId { get; set; }

    public int? BaubleTypeId { get; set; }

    public int? NewYearDecorationTypeId { get; set; }

    public bool IsFacebookShareOn { get; set; }

    public int? PriorityDays { get; set; }

    public int? AnnouncementModuleId { get; set; }

    public DateTime PublishDate { get; set; }

    public DateTime DeadlineDate { get; set; }

    public bool IsExpired { get; set; }

    public DateTime? RenewalDate { get; set; }

    public DateTime? PriorityExpireDate { get; set; }

    public bool IsPreview { get; set; }

    public int? DetailsDistributionChannelId { get; set; }

    public DateTime? PriorityActivationDate { get; set; }

    public bool IsActive { get; set; }
}
