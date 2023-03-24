using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Moderation
{
    public long ModerationId { get; set; }

    public long EventId { get; set; }

    public long? RequestId { get; set; }

    public long? ContentId { get; set; }

    public int ModerationStatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }
}
