using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class LanguageProficiencyLevel
{
    public int LanguageProficiencyLevelId { get; set; }

    public string Name { get; set; } = null!;

    public int RankId { get; set; }
}
