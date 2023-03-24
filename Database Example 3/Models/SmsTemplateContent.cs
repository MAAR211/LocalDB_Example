using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SmsTemplateContent
{
    public long SmsTemplateContentId { get; set; }

    public long SmsTemplateId { get; set; }

    public int LanguageCharsetId { get; set; }

    public string Content { get; set; } = null!;
}
