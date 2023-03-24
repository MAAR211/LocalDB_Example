using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityIndexTag
{
    public long EntityIndexTagId { get; set; }

    public int EntityTypeId { get; set; }

    public int EntityId { get; set; }

    public string EntityAttributeId { get; set; } = null!;

    public long IndexTagId { get; set; }
}
