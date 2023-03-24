using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserPreference
{
    public int UserPreferenceId { get; set; }

    public long UserId { get; set; }

    public int SettingId { get; set; }

    public string? ValueString { get; set; }

    public long? ValueInteger { get; set; }

    public bool? ValueBool { get; set; }

    public DateTime? ValueDate { get; set; }
}
