using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Entity
{
    public int EntityTypeId { get; set; }

    public int EntityId { get; set; }

    public DateTime InsertDate { get; set; }
}
