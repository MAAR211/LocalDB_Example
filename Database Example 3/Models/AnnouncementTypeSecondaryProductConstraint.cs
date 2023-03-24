using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementTypeSecondaryProductConstraint
{
    public int AnnouncementTypeSecondaryProductConstraintId { get; set; }

    public int AnnouncementTypeId { get; set; }

    public int SecondaryProductTypeId { get; set; }

    public int? SecondaryProductId { get; set; }

    public bool IsProviderSpecific { get; set; }

    public int? ProviderWebsiteId { get; set; }

    public bool IsDenied { get; set; }
}
