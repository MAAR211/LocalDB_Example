using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SuspendedEmailAddress
{
    public long SuspendedEmailAddressId { get; set; }

    public string? EmailDomain { get; set; }

    public string? EmailAddress { get; set; }

    public bool IsSuspended { get; set; }

    public bool IsDomain { get; set; }

    public bool IsProcessed { get; set; }

    public string? SuspendType { get; set; }

    public string? BounceType { get; set; }

    public string? BounceSubType { get; set; }

    public string? ComplaintType { get; set; }

    public DateTime? CreateDate { get; set; }
}
