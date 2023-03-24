using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerGroup
{
    public long CustomerGroupId { get; set; }

    public long CustomerId { get; set; }

    public int GroupId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }
}
