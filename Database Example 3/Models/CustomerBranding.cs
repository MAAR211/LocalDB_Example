using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerBranding
{
    public long CustomerBrandingId { get; set; }

    public long CustomerId { get; set; }

    public bool IsActive { get; set; }

    public string? AnnouncementDetailsDesktopBgImage { get; set; }

    public string? AnnouncementDetailsMobileBgImage { get; set; }

    public string? CustomerCoverImage { get; set; }

    public string? AnnouncementDetailsBgColor { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public string? AnnouncementTileColor { get; set; }

    public bool? IsAnnouncementDetailsBackgroundColorCustomizable { get; set; }

    public bool? IsAnnouncementDetailsCoverPhotoCustomizable { get; set; }

    public bool? AnnouncementDetailsDisplayOtherAnnouncements { get; set; }

    public bool? AnnouncementDetailsDisplayCvBox { get; set; }

    public bool? IsCustomerDetailsBackgroundColorCustomizable { get; set; }

    public int? BrandingAnnouncementTileTypeId { get; set; }

    public string? CustomerDetailsBgColor { get; set; }
}
