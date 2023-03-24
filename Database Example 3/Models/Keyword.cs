using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Keyword
{
    public int KeywordId { get; set; }

    public string KeywordText { get; set; } = null!;
}
