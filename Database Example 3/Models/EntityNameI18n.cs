using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EntityNameI18n
{
    public long I18nId { get; set; }

    public string EntityObjectId { get; set; } = null!;

    public string? EntityObjectName { get; set; }

    public int EntityId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string Name { get; set; } = null!;
}
