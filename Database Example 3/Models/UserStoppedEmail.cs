using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserStoppedEmail
{
    public long UserStoppedEmailId { get; set; }

    public long UserId { get; set; }

    public int EmailTypeId { get; set; }

    public bool IsActive { get; set; }

    public long CreateUserId { get; set; }

    public DateTime CreateDate { get; set; }
}
