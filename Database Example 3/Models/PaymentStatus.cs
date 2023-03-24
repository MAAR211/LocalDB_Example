using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActual { get; set; }
}
