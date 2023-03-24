using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Feature
{
    public int FeatureId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public int? FeatureTypeId { get; set; }
}
