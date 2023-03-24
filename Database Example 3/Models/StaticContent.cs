using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class StaticContent
{
    public int StaticContentId { get; set; }

    public string Alias { get; set; } = null!;

    public int TitleResouceId { get; set; }

    public int ContentResouceId { get; set; }
}
