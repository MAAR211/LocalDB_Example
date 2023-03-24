using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityAttribute1
{
    public int EntityAttributeId { get; set; }

    public int EntityTypeId { get; set; }

    public int EntityAttributeBundleId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsUnique { get; set; }

    public int Rank { get; set; }

    public int DataTypeId { get; set; }

    public bool IsValueReference { get; set; }

    public int? ValueEntityTypeId { get; set; }

    public string? ValueEntityObjectId { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsComplex { get; set; }

    public bool IsSystemSpecific { get; set; }
}
