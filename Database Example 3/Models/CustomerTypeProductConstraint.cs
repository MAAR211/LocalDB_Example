using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerTypeProductConstraint
{
    public int CustomerTypeProductConstraintId { get; set; }

    public int CustomerTypeId { get; set; }

    public int ProductTypeId { get; set; }

    public int? ProductId { get; set; }

    public bool IsProviderSpecific { get; set; }

    public int? ProviderWebsiteId { get; set; }

    public bool IsDenied { get; set; }
}
