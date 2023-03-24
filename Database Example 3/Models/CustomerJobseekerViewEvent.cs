using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerJobseekerViewEvent
{
    public long JobseekerViewEventId { get; set; }

    public long JobseekerId { get; set; }

    public long UserId { get; set; }

    public long CustomerId { get; set; }

    public long CustomerAgentId { get; set; }

    public DateTime EventDate { get; set; }

    public long? CvDatabaseAccessTokenId { get; set; }

    public int SourceId { get; set; }

    public long? CvBoxAccessTokenId { get; set; }

    public long? AnnouncementId { get; set; }

    public long? MatchingId { get; set; }
}
