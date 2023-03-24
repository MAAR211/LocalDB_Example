﻿using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class DrivingLicence
{
    public int DrivingLicenceId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }
}
