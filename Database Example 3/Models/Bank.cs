using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Bank
{
    public int BankId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
