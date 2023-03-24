using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementApplicationDetail
{
    public long AnnouncementId { get; set; }

    public string? Email { get; set; }

    public bool? IsEmailSameAsContactPerson { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? IsPhoneSameAsContactPerson { get; set; }

    public string? WebsiteUrl { get; set; }

    public bool? ForwardApplicationsToEmail { get; set; }

    public bool? RecipientCustomerAgentId { get; set; }

    public string? ApplicationUrl { get; set; }

    public string? ApplicationAddress { get; set; }
}
