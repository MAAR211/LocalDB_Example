using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SubscriberOccupationCategory
{
    public long SubscriberOccupationCategoryId { get; set; }

    public long SubscriberId { get; set; }

    public long OccupationCategoryId { get; set; }
}
