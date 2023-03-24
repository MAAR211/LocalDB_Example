using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerSavedJobseekerFolder
{
    public long CustomerSavedJobseekerFolderId { get; set; }

    public long CustomerId { get; set; }

    public string FolderName { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
