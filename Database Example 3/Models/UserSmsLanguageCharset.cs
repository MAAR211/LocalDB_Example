using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserSmsLanguageCharset
{
    public long UserSmsLanguageCharsetId { get; set; }

    public long UserId { get; set; }

    public int SmsTypeId { get; set; }

    public int LanguageCharsetId { get; set; }

    public long CreateUserId { get; set; }

    public DateTime CreateDate { get; set; }
}
