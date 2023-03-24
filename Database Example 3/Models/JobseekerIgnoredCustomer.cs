using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerIgnoredCustomer
{
    public long JobseekerIgnoredCustomerId { get; set; }

    public long JobseekerId { get; set; }

    public long CustomerId { get; set; }
}
