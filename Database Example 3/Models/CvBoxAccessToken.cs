using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvBoxAccessToken
{
    public long CvBoxAccessTokenId { get; set; }

    public long CvBoxId { get; set; }

    public bool PlaceInFrontPageCvTopSection { get; set; }

    public bool PlaceInCustomerProfileCvSection { get; set; }

    public bool PlaceInCvBoxPage { get; set; }

    public int? CvBoxPageSectionId { get; set; }

    public bool DecorateInCustomerAnnouncements { get; set; }

    public bool IsCvViewAllowed { get; set; }

    public bool IsCvSendAllowed { get; set; }

    public int StatusId { get; set; }

    public DateTime? CvSendExpireDate { get; set; }

    public DateTime? CvViewExpireDate { get; set; }

    public DateTime? TokenExpireDate { get; set; }

    public long RequestUserId { get; set; }

    public DateTime CreateDate { get; set; }

    public long? ProcessUserId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public long? TerminateUserId { get; set; }

    public DateTime? TerminationDate { get; set; }

    public long RequestCustomerAgentId { get; set; }

    public int CvSendDayCount { get; set; }

    public int CvViewDayCount { get; set; }

    public bool PlaceInFrontPageSliderSection { get; set; }

    public bool PlaceInAnnouncementDetailsSliderSection { get; set; }
}
