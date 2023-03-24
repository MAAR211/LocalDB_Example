using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TargetAudience
{
    public int TargetAudienceId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
