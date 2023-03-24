using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public int SellerId { get; set; }

    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }

    public DateTime CreateDate { get; set; }

    public int? ProviderWebsiteId { get; set; }

    public decimal? ListPrice { get; set; }
}
