using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerFile
{
    public long JobseekerFileId { get; set; }

    public long JobseekerId { get; set; }

    public string? ContentType { get; set; }

    public string Filename { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }
}
