using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductIncompatibilityConstraint
{
    public int ProductIncompatibilityConstraintId { get; set; }

    public int? ProductGroupId { get; set; }

    public int? ProductId { get; set; }

    public int? ChannelId { get; set; }

    public int? IncompatibleProductGroupId { get; set; }

    public int? IncompatibleProductId { get; set; }

    public int? IncompatibleChannelId { get; set; }

    public bool IsActive { get; set; }
}
