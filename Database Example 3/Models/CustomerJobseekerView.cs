using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerJobseekerView
{
    public long CustomerJobseekerViewId { get; set; }

    public long CustomerId { get; set; }

    public long JobseekerId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastViewDate { get; set; }
}
