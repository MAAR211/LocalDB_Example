using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ApplicationMethod
{
    public int ApplicationMethodId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
