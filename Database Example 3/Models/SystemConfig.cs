using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SystemConfig
{
    public int SystemConfigId { get; set; }

    public int MasterSystemConfigId { get; set; }

    public int? ParentSystemConfigId { get; set; }

    public string KeyName { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool IsValueItem { get; set; }

    public int? Rank { get; set; }

    public int? DataTypeId { get; set; }

    public string? ValueString { get; set; }

    public long? ValueInteger { get; set; }

    public bool? ValueBool { get; set; }

    public DateTime? ValueDate { get; set; }

    public double? ValueFloat { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public bool IsProviderWebsiteSpecific { get; set; }

    public int? ProviderWebsiteId { get; set; }

    public string? ValueObject { get; set; }
}
