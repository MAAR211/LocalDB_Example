using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PortfolioAccountManager
{
    public long PortfolioAccountManagerId { get; set; }

    public long PortfolioId { get; set; }

    public long AccountManagerAdminId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long IsCurrent { get; set; }

    public long CreateUserId { get; set; }
}
