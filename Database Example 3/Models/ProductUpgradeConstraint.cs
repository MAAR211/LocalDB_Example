using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductUpgradeConstraint
{
    public int ProductUpgradeConstraintId { get; set; }

    public int? OriginalProductGroupId { get; set; }

    public int? OriginalProductId { get; set; }

    public int? OriginalProductChannelId { get; set; }

    public int? NewProductGroupId { get; set; }

    public int? NewProductId { get; set; }

    public int? NewProductChannelId { get; set; }

    public bool IsUpgradeDenied { get; set; }

    public bool IsAddDenied { get; set; }

    public bool IsActive { get; set; }
}
