using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Holiday
{
    public long HolidayId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Day { get; set; }

    public bool IsWeekend { get; set; }
}
