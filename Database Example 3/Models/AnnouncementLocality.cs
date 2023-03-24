using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementLocality
{
    public long AnnouncementLocalityId { get; set; }

    public long AnnouncementId { get; set; }

    public int? LocalityId { get; set; }
}
