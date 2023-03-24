using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Admin
{
    public long AdminId { get; set; }

    public long UserId { get; set; }

    public string? Position { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneExtension { get; set; }

    public string? MobileNumber { get; set; }
}
