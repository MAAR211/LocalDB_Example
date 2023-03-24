using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TermTag
{
    public int TermTagId { get; set; }

    public string Text { get; set; } = null!;

    public double Weight { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
