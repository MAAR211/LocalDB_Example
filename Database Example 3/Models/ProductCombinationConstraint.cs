using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductCombinationConstraint
{
    public int ProductCombinationConstraintId { get; set; }

    public int? ProductGroupId { get; set; }

    public int? ProductId { get; set; }

    public int? ChannelId { get; set; }

    public bool IsStandalone { get; set; }

    public int MaxAllowedItemCountPerOrder { get; set; }

    public int? DependencyProductGroupId { get; set; }

    public int? DependencyProductId { get; set; }

    public int? DependencyChannelId { get; set; }

    public bool IsActive { get; set; }
}
