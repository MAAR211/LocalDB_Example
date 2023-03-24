using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class MonthlyPlanProductType
{
    public long MonthlyPlanProductTypeId { get; set; }

    public long MonthlyPlanId { get; set; }

    public int ProductTypeId { get; set; }

    public int? WebsiteId { get; set; }

    public int? TotalCount { get; set; }

    public int? SoldCount { get; set; }
}
