using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Request
{
    public long RequestId { get; set; }

    public long EventId { get; set; }

    public long HandleId { get; set; }

    public int RequestActionId { get; set; }

    public int ConceptRequestActionId { get; set; }

    public bool? IsContentOverridable { get; set; }

    public bool IsFulfilled { get; set; }

    public int? ModerationId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? FulfilDate { get; set; }

    public long? FulfilUserId { get; set; }
}
