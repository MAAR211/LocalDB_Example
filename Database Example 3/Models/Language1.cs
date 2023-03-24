using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Language1
{
    public string LanguageId { get; set; } = null!;

    public string CultureName { get; set; } = null!;

    public string NativeName { get; set; } = null!;

    public string ShortNativeName { get; set; } = null!;

    public bool IsUi { get; set; }

    public bool IsEntryData { get; set; }
}
