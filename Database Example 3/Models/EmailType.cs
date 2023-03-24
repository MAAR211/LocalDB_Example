using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailType
{
    public int EmailTypeId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsSwitchable { get; set; }

    public bool IsSwitchableByClient { get; set; }
}
