using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ModerationContext
{
    public long ModerationContextId { get; set; }

    public long HandleId { get; set; }

    public int RequestActionId { get; set; }

    public bool IsApproveBlocked { get; set; }

    public bool IsRejectBlocked { get; set; }

    public bool? IsParentBound { get; set; }

    public bool HasPendingContent { get; set; }

    public bool IsDependency { get; set; }

    public bool HasExternalApproveBlock { get; set; }

    public string? ExternalApproveMessages { get; set; }

    public bool HasExternalRejectBlock { get; set; }

    public string? ExternalRejectMessages { get; set; }

    public bool IsLocked { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime? BlockingChangeDate { get; set; }

    public DateTime? LockingChangeDate { get; set; }

    public long? LockUserId { get; set; }
}
