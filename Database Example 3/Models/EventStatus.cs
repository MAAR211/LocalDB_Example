using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EventStatus
{
    public int EventStatusId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
}
