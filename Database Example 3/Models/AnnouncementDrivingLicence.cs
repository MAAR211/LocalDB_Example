using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementDrivingLicence
{
    public long AnnouncementDrivingLicenceId { get; set; }

    public long AnnouncementId { get; set; }

    public long DrivingLicenceId { get; set; }
}
