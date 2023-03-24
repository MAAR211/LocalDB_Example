using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ModerationStatus
{
    public long ModerationStatusId { get; set; }

    public string Name { get; set; } = null!;
}
