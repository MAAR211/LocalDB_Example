using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Subscriber
{
    public long SubscriberId { get; set; }

    public string? SubscriberCode { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int SubscriberStatusId { get; set; }

    public bool DailyDigestOn { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public int OriginWebsiteId { get; set; }

    public int? MigratedFromOriginWebsiteId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public string? EmailVerificationResendToken { get; set; }

    public int EmailVerificationResendAttempts { get; set; }
}
