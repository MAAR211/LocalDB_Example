using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityAttribute
{
    public string EntityAttributeId { get; set; } = null!;

    public int EntityTypeId { get; set; }

    public double Weight { get; set; }

    public string Description { get; set; } = null!;
}
