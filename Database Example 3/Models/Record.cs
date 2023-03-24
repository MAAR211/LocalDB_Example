using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Record
{
    public long RecordId { get; set; }

    public long ActionId { get; set; }

    public string EntityObjectId { get; set; } = null!;

    public long EntityId { get; set; }

    public string Attribute { get; set; } = null!;

    public string Context { get; set; } = null!;

    public string? ValueString { get; set; }

    public long? ValueInteger { get; set; }

    public bool? ValueBool { get; set; }

    public DateTime? ValueDate { get; set; }

    public double? ValueFloat { get; set; }
}
