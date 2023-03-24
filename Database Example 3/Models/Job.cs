using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Job
{
    public long JobId { get; set; }

    public string Action { get; set; } = null!;

    public string AdditionalInfo { get; set; } = null!;

    public short Priority { get; set; }

    public int Status { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
