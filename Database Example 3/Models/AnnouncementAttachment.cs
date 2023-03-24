using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementAttachment
{
    public long AnnouncementId { get; set; }

    public string Filename { get; set; } = null!;
}
