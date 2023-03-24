using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerLocalitySubscription
{
    public long JobseekerLocalitySubscriptionId { get; set; }

    public long JobseekerId { get; set; }

    public int LocalityId { get; set; }
}
