using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class GeneratedDocumentTemplate
{
    public long GeneratedDocumentTemplateId { get; set; }

    public string KeyName { get; set; } = null!;

    public string? Name { get; set; }

    public int TypeId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
