using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EventParticipationPackage
{
    public int EventParticipationPackageId { get; set; }

    public int? EventId { get; set; }

    public string? Name { get; set; }

    public int BoothTypeId { get; set; }

    public bool IsVideoAvailable { get; set; }

    public int MaxAllowedNumber { get; set; }

    public bool IsActive { get; set; }
}
