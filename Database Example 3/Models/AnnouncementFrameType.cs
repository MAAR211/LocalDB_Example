using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementFrameType
{
    public int AnnouncementFrameTypeId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IndexNumber { get; set; }
}
