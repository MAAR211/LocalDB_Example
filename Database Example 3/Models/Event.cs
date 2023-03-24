using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Event
{
    public long EventId { get; set; }

    public int EventSpaceId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }
}
