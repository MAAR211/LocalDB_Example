using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerOccupationCategorySubscription
{
    public long JobseekerOccupationCategorySubscriptionId { get; set; }

    public long JobseekerId { get; set; }

    public long OccupationCategoryId { get; set; }
}
