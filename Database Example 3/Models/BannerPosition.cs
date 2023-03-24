using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class BannerPosition
{
    public int BannerPositionId { get; set; }

    public int HeadBannerPositionId { get; set; }

    public string Name { get; set; } = null!;

    public string KeyName { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public bool IsActive { get; set; }

    public string? DesktopWidth { get; set; }

    public string? DesktopHeight { get; set; }

    public string? ResponsiveWidth { get; set; }

    public string? ResponsiveHeight { get; set; }
}
