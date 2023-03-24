using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EventVisitor
{
    public long EventVisitorId { get; set; }

    public long JobseekerId { get; set; }

    public int EventId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public bool IsDeleted { get; set; }
}
