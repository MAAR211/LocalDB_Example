using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int ProductTypeId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsInStock { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Code { get; set; }

    public bool IsLegacy { get; set; }

    public string ProductCode { get; set; } = null!;
}
