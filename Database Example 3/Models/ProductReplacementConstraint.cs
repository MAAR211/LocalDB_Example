using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductReplacementConstraint
{
    public int ProductReplacementConstraintId { get; set; }

    public int? ChannelId { get; set; }

    public int ProductId { get; set; }

    public int ReplacementProductId { get; set; }

    public int Priority { get; set; }

    public bool IsActive { get; set; }
}
