using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PromoEmailPortfolio
{
    public long PromoEmailPortfolioId { get; set; }

    public long PromoEmailTemplateId { get; set; }

    public long PortfolioId { get; set; }

    public bool IsDeleted { get; set; }
}
