using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SettingI18n
{
    public int SettingI18nId { get; set; }

    public int SettingId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
