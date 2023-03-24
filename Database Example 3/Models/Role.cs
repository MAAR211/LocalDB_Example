using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsBasicRole { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
