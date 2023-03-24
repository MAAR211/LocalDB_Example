using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SmsMessage
{
    public long SmsMessageId { get; set; }

    public string Address { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int StatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public int TypeId { get; set; }

    public int SendAttemptCount { get; set; }

    public int MaxSendAttemptCount { get; set; }
}
