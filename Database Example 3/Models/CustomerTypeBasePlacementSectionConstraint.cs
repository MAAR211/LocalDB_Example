using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerTypeBasePlacementSectionConstraint
{
    public int CustomerTypeBasePlacementSectionConstraintId { get; set; }

    public int CustomerTypeId { get; set; }

    public int BasePlacementSectionId { get; set; }

    public bool IsProviderSpecific { get; set; }

    public int? ProviderWebsiteId { get; set; }

    public bool IsDenied { get; set; }
}
