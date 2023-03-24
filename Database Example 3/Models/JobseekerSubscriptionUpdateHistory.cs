using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerSubscriptionUpdateHistory
{
    public long JobseekerSubscriptionUpdateHistoryId { get; set; }

    public long JobseekerId { get; set; }

    public DateTime UpdateDate { get; set; }

    public int UpdateUserId { get; set; }
}
