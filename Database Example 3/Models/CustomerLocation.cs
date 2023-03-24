using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerLocation
{
    public long CustomerLocationId { get; set; }

    public long CustomerId { get; set; }

    public int CountryId { get; set; }

    public int? CityLocalityId { get; set; }

    public string? Title { get; set; }

    public string? Address { get; set; }

    public decimal? Longitude { get; set; }

    public decimal? Latitude { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
