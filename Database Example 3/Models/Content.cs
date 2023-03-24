using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Content
{
    public long ContentId { get; set; }

    public long RequestId { get; set; }

    public int EntityAttributeId { get; set; }

    public int ContentActionId { get; set; }

    public bool IsProcessed { get; set; }

    public bool? IsOverridden { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsDirectEntityReference { get; set; }

    public int DataTypeId { get; set; }

    public string? CurrentValueString { get; set; }

    public long? CurrentValueInteger { get; set; }

    public bool? CurrentValueBool { get; set; }

    public DateTime? CurrentValueDate { get; set; }

    public double? CurrentValueFloat { get; set; }

    public string? NewValueString { get; set; }

    public long? NewValueInteger { get; set; }

    public bool? NewValueBool { get; set; }

    public DateTime? NewValueDate { get; set; }

    public double? NewValueFloat { get; set; }

    public long? NewValueHashCode { get; set; }

    public int? ModerationId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
