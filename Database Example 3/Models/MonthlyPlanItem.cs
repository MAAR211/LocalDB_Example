using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class MonthlyPlanItem
{
    public long MonthlyPlanItemId { get; set; }

    public long MonthlyPlanId { get; set; }

    public string ProductCode { get; set; } = null!;

    public int? WebsiteId { get; set; }

    public int ProductTypeId { get; set; }

    public int? Count { get; set; }
}
