using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class RoleFeature
{
    public int RoleFeatureId { get; set; }

    public int RoleId { get; set; }

    public int FeatureId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
