using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EventParticipant
{
    public int EventParticipantId { get; set; }

    public int EventId { get; set; }

    public long CustomerId { get; set; }

    public int EventParticipationPackageId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public long? LastModifiedUserId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public int EventCvDatabaseAccessStatusId { get; set; }
}
