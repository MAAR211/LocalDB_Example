using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Portfolio
{
    public long PortfolioId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? Comment { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public long CreateUserId { get; set; }

    public long? LastModifiedUserId { get; set; }
}
