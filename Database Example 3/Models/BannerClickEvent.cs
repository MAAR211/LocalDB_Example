using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class BannerClickEvent
{
    public int BannerClickEventId { get; set; }

    public int BannerId { get; set; }

    public DateTime CreateDate { get; set; }
}
