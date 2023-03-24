using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PaymentType
{
    public int PaymentTypeId { get; set; }

    public string Name { get; set; } = null!;
}
