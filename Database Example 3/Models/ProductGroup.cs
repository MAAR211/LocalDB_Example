using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductGroup
{
    public int ProductGroupId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
