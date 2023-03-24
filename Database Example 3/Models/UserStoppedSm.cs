using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserStoppedSm
{
    public long UserStoppedSmsId { get; set; }

    public long UserId { get; set; }

    public int SmsTypeId { get; set; }

    public int StopReasonId { get; set; }

    public bool IsActive { get; set; }

    public long CreateUserId { get; set; }

    public DateTime CreateDate { get; set; }
}
