using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserFeature
{
    public int UserFeatureId { get; set; }

    public int UserId { get; set; }

    public int FeatureId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
