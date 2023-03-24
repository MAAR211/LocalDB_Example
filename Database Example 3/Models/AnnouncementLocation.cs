using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementLocation
{
    public long AnnouncementLocationId { get; set; }

    public long AnnouncementId { get; set; }

    public long? CustomerLocationId { get; set; }
}
