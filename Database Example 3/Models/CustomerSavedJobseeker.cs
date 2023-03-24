using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerSavedJobseeker
{
    public long CustomerSavedJobseekerId { get; set; }

    public long CustomerId { get; set; }

    public long JobseekerId { get; set; }

    public DateTime CreateDate { get; set; }

    public long? CustomerSavedJobseekerFolderId { get; set; }
}
