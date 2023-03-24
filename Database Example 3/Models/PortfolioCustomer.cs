using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PortfolioCustomer
{
    public long PortfolioCustomerId { get; set; }

    public long CustomerId { get; set; }

    public long PortfolioId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsCurrent { get; set; }

    public long CreateUserId { get; set; }
}
