using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Resource
{
    public int ResourceId { get; set; }

    public int ResourceScopeId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public bool IsProviderWebsiteSpecific { get; set; }

    public int? ProviderWebsiteId { get; set; }
}
