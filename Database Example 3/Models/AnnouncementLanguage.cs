using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementLanguage
{
    public long AnnouncementLanguageId { get; set; }

    public long AnnouncementId { get; set; }

    public long WorldLanguageId { get; set; }

    public bool IsMandatory { get; set; }
}
