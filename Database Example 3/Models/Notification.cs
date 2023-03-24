using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Notification
{
    public long NotificationId { get; set; }

    public int TypeId { get; set; }

    public int SubTypeId { get; set; }

    public int TargetEntityTypeId { get; set; }

    public long TargetEntityId { get; set; }

    public int StatusId { get; set; }

    public int ProcessAttemptCount { get; set; }

    public int MaxProcessAttemptCount { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ScheduledProcessDate { get; set; }

    public DateTime? ActualProcessDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public bool IsLast { get; set; }

    public string Key { get; set; } = null!;
}
