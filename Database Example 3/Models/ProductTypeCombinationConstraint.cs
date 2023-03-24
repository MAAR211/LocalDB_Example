using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductTypeCombinationConstraint
{
    public int ProductTypeCombinationConstraintId { get; set; }

    public int CoreProductTypeId { get; set; }

    public int SecondaryProductTypeId { get; set; }

    public bool IsAllowed { get; set; }
}
