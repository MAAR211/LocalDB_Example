using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerDocumentContentPlainText
{
    public long Id { get; set; }

    public long JobseekerId { get; set; }

    public long JobseekerDocumentId { get; set; }

    public string Filename { get; set; } = null!;

    public string? PlainText { get; set; }

    public string? MetaData { get; set; }

    public DateTime LastUpdateDate { get; set; }
}
