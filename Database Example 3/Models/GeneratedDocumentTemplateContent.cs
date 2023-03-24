using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class GeneratedDocumentTemplateContent
{
    public long GeneratedDocumentTemplateContentId { get; set; }

    public long GeneratedDocumentTemplateId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? Header { get; set; }

    public string? Footer { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
