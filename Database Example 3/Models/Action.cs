using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Action
{
    public long ActionId { get; set; }

    public string ActionName { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public long SourceUserId { get; set; }
}
