using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerIgnoredCustomer
{
    public long CustomerIgnoredCustomerId { get; set; }

    public long CustomerId { get; set; }

    public long IgnoredCustomerId { get; set; }
}
