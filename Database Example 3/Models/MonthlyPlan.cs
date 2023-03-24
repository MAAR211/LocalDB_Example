using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class MonthlyPlan
{
    public long MonthlyPlanId { get; set; }

    public long? PortfolioId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int TotalDays { get; set; }

    public int Holidays { get; set; }

    public int WorkingDays { get; set; }

    public int Saturdays { get; set; }

    public decimal? Payments { get; set; }

    public decimal? Invoices { get; set; }

    public int? SharesPlan { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public bool IsEditable { get; set; }
}
