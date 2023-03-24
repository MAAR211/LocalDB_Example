using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ObjectHashCode
{
    public int Id { get; set; }

    public string HashCode { get; set; } = null!;

    public int ObjectId { get; set; }

    public short ObjectType { get; set; }

    public DateTime ActionDate { get; set; }
}
