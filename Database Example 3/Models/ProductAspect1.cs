using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductAspect1
{
    public string ProductAspectId { get; set; } = null!;

    public int ProductTypeId { get; set; }

    public int DataTypeId { get; set; }

    public bool IsMulti { get; set; }
}
