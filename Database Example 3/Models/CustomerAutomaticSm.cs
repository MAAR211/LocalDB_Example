using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerAutomaticSm
{
    public long CustomerAutomaticSmsId { get; set; }

    public long CustomerId { get; set; }

    public long CustomerAgentId { get; set; }

    public int SmsTypeId { get; set; }

    public string? ContentInfo { get; set; }

    public DateTime SendDate { get; set; }

    public long SmsMessageId { get; set; }
}
