using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProductTypeAvailabilityConstraint
{
    public int ProductTypeAvailabilityConstraintId { get; set; }

    public int ProductTypeId { get; set; }

    public bool? IsAvailable { get; set; }
}
