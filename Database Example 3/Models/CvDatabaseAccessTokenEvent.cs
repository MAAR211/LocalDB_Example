using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvDatabaseAccessTokenEvent
{
    public long CvDatabaseAccessTokenEventId { get; set; }

    public long CvDatabaseAccessTokenId { get; set; }

    public int EventId { get; set; }
}
