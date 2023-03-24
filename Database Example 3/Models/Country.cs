using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string Alpha2Code { get; set; } = null!;

    public string Alpha3Code { get; set; } = null!;

    public short NumericCode { get; set; }
}
