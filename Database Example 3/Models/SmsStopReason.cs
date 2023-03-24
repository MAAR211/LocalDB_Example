using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SmsStopReason
{
    public int SmsStopReasonId { get; set; }

    public int SmsTypeId { get; set; }

    public int StopReasonId { get; set; }
}
