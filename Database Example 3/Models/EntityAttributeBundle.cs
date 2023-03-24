using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityAttributeBundle
{
    public int EntityAttributeBundleId { get; set; }

    public int EntityTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public int Rank { get; set; }

    public int SensitivityLevel { get; set; }

    public DateTime CreateDate { get; set; }
}
