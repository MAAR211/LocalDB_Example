using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ProviderWebsite
{
    public int ProviderWebsiteId { get; set; }

    public int IndexNumber { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool IsExternal { get; set; }

    public string Url { get; set; } = null!;

    public string LogoFileName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsAnnouncementProvider { get; set; }

    public bool IsCvProvider { get; set; }

    public bool IsCategorized { get; set; }

    public bool IsMain { get; set; }

    public short? LaunchYear { get; set; }

    public bool IsCvBoxProvider { get; set; }

    public bool IsRegistrable { get; set; }

    public bool IsPreferred { get; set; }
}
