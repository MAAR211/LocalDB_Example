using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SpecialPriceOffer
{
    public long SpecialPriceOfferId { get; set; }

    public int? CustomerTypeId { get; set; }

    public int? CustomerGroupId { get; set; }

    public int ItemId { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
