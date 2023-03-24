using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SmsType
{
    public int SmsTypeId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsSwitchable { get; set; }

    public bool IsSwitchableByClient { get; set; }
}
