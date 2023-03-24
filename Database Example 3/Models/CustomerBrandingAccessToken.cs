using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerBrandingAccessToken
{
    public long CustomerBrandingAccessTokenId { get; set; }

    public long CustomerBrandingId { get; set; }

    public bool IsAnnouncementDetailsBackgroundColorCustomizable { get; set; }

    public bool IsAnnouncementDetailsCoverPhotoCustomizable { get; set; }

    public bool AnnouncementDetailsDisplayOtherAnnouncements { get; set; }

    public bool AnnouncementDetailsDisplayCvBox { get; set; }

    public int BrandingAnnouncementTileTypeId { get; set; }

    public bool IsCustomerDetailsBackgroundColorCustomizable { get; set; }

    public int DayCount { get; set; }

    public int StatusId { get; set; }

    public DateTime? TokenExpireDate { get; set; }

    public long RequestUserId { get; set; }

    public long RequestCustomerAgentId { get; set; }

    public DateTime CreateDate { get; set; }

    public long? ProcessUserId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public long? TerminateUserId { get; set; }

    public DateTime? TerminationDate { get; set; }
}
