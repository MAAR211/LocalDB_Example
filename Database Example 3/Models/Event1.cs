using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Event1
{
    public int EventId { get; set; }

    public string Name { get; set; } = null!;

    public string UrlShortName { get; set; } = null!;

    public DateTime OnlineEventStartDate { get; set; }

    public DateTime OnlinelEventEndDate { get; set; }

    public DateTime OnsiteEventStartDate { get; set; }

    public DateTime OnsiteEventEndDate { get; set; }

    public int StatusId { get; set; }

    public int CityId { get; set; }

    public string EventVenue { get; set; } = null!;

    public decimal? EventVenueLatitude { get; set; }

    public decimal? EventVenueLongtitude { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public int Visitors { get; set; }
}
