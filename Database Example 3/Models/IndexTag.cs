using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class IndexTag
{
    public long IndexTagId { get; set; }

    public string? LanguageId { get; set; }

    public int DataTypeId { get; set; }

    public string? ValueString { get; set; }

    public long? ValueInteger { get; set; }

    public long? ValueIntegerFrom { get; set; }

    public long? ValueIntegerTo { get; set; }

    public bool? ValueBool { get; set; }

    public DateTime? ValueDate { get; set; }

    public int? ValueLength { get; set; }

    public int HashCode { get; set; }

    public double Weight { get; set; }

    public bool IsDeleted { get; set; }
}
