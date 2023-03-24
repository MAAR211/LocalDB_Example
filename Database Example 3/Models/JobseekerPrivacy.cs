using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerPrivacy
{
    public int JobseekerPrivacyId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;
}
