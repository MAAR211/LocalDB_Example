using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Seller
{
    public int SellerId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsHost { get; set; }

    public string? WebsiteUrl { get; set; }

    public string? LogoUrl { get; set; }
}
