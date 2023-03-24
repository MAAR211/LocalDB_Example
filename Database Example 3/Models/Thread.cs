using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Thread
{
    public long ThreadId { get; set; }

    public int ThreadRelatedObjectTypeId { get; set; }

    public long ThreadRelatedObjectId { get; set; }

    public int ThreadTopicId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public bool IsAlive { get; set; }

    public DateTime? LastPostDate { get; set; }
}
