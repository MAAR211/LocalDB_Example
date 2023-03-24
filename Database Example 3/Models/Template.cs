using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Template
{
    public long TemplateId { get; set; }

    public string KeyName { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public string EmaiTemplateGenerationPath { get; set; } = null!;

    public string? Subject { get; set; }
}
