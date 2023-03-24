using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProviderWebsiteOccupationCategory
{
    public int ProviderWebsiteOccupationCategoryId { get; set; }

    public int ProviderWebsiteId { get; set; }

    public int OccupationCategoryId { get; set; }
}
