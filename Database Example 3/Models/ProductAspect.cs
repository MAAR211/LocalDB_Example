using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductAspect
{
    public int ProductId { get; set; }

    public string ProductAspectId { get; set; } = null!;

    public int? DataTypeId { get; set; }

    public string? ValueString { get; set; }

    public long? ValueInteger { get; set; }

    public bool? ValueBool { get; set; }

    public DateTime? ValueDate { get; set; }

    public double? ValueFloat { get; set; }

    public string? ValueComplex { get; set; }
}
