using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Banner
{
    public int BannerId { get; set; }

    public int PositionId { get; set; }

    public int StatusId { get; set; }

    public int TypeId { get; set; }

    public int TargetId { get; set; }

    public string Name { get; set; } = null!;

    public string? ImageFileName { get; set; }

    public string? Link { get; set; }

    public string? Code { get; set; }

    public DateTime CreateDate { get; set; }

    public int CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public int? LastChangeUserId { get; set; }

    public DateTime? ActivationDate { get; set; }

    public int? LastActivationUserId { get; set; }

    public DateTime? DeactivationDate { get; set; }

    public double IsOpenNewTab { get; set; }
}
