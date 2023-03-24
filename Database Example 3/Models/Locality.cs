using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Locality
{
    public int LocalityId { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsCity { get; set; }

    public bool? IsCapital { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public int IndexNumber { get; set; }
}
