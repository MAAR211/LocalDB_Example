using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementLogo
{
    public long AnnouncementId { get; set; }

    public string LogoFilename { get; set; } = null!;

    public string LogoThumbnail1Filename { get; set; } = null!;
}
