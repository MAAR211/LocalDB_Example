using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class BoothType
{
    public int BoothTypeId { get; set; }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }

    public bool? IsActive { get; set; }
}
