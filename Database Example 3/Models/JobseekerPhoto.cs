using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerPhoto
{
    public long JobseekerId { get; set; }

    public string Filename { get; set; } = null!;
}
