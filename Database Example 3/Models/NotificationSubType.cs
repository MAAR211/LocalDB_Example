using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class NotificationSubType
{
    public int NotificationSubTypeId { get; set; }

    public int NotificationTypeId { get; set; }

    public string Name { get; set; } = null!;
}
