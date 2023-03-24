using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductGroupProduct
{
    public int ProducGroupProductId { get; set; }

    public int? ProductGroupId { get; set; }

    public int? ProductId { get; set; }
}
