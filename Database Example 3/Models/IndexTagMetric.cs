using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class IndexTagMetric
{
    public long IndexTagMetricId { get; set; }

    public long IndexTagId { get; set; }

    public string TagTrait { get; set; } = null!;

    public double Metric { get; set; }

    public bool IsMajorTrait { get; set; }

    public int TraitLength { get; set; }
}
