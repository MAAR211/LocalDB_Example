using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerDrivingLicence
{
    public long JobseekerDrivingLicenceId { get; set; }

    public long JobseekerId { get; set; }

    public long DrivingLicenceId { get; set; }
}
