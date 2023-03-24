using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class OrderItem
{
    public long OrderItemId { get; set; }

    public long OrderId { get; set; }

    public int ItemNumber { get; set; }

    public int ItemId { get; set; }

    public bool? IsDetailPending { get; set; }

    public long? DetailId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public bool IsUpgrade { get; set; }

    public bool IsOverriden { get; set; }

    public long? OverrideOrderItemId { get; set; }

    public decimal TotalPrice { get; set; }

    public long? OriginalOrderItemId { get; set; }

    public bool IsOverridePending { get; set; }

    public int? UsedQuantityBeforeOverride { get; set; }

    public string? Customization { get; set; }
}
