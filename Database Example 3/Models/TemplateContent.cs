using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TemplateContent
{
    public long TemplateContentId { get; set; }

    public long TemplateId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string? Subject { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
