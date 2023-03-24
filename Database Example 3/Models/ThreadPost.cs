using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ThreadPost
{
    public long ThreadPostId { get; set; }

    public long ThreadId { get; set; }

    public string Text { get; set; } = null!;

    public int PostingChannelId { get; set; }

    public long? ReplyToPostId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public bool IsLocked { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }
}
