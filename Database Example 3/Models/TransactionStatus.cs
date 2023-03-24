using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TransactionStatus
{
    public int TransactionStatusId { get; set; }

    public string Name { get; set; } = null!;
}
