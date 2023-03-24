using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityType1
{
    public int EntityTypeId { get; set; }

    public string KeyName { get; set; } = null!;

    public int HeadEntityTypeId { get; set; }

    public int? ParentEntityTypeId { get; set; }

    public string? Name { get; set; }
}
