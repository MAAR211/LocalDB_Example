using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerAgent
{
    public long CustomerAgentId { get; set; }

    public int CustomerAgentStatusId { get; set; }

    public long CustomerId { get; set; }

    public long? UserId { get; set; }

    public bool IsProfileOwner { get; set; }

    public bool IsVirtualAdminAgent { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Phone1Number { get; set; }

    public string? Phone1Extension { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public int? LastChangeUserId { get; set; }

    public string? Position { get; set; }

    public string? MobilePhoneNumber { get; set; }

    public string? MobilePhoneNumber2 { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }
}
