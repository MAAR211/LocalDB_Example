using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class ResourceI18n
{
    public int ResourceI18nId { get; set; }

    public int ResourceId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string Value { get; set; } = null!;
}
