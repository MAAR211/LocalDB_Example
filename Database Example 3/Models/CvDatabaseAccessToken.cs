using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvDatabaseAccessToken
{
    public long CvDatabaseAccessTokenId { get; set; }

    public long CvDatabaseAccessTokenRequestId { get; set; }

    public long CustomerId { get; set; }

    public int ViewCount { get; set; }

    public int StatusId { get; set; }

    public int DayCount { get; set; }

    public int DemoViewCountLimit { get; set; }

    public int TotalViewCountLimit { get; set; }

    public DateTime? ExpireDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public DateTime CreateDate { get; set; }

    public long? TerminateUserId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public long? ProcessUserId { get; set; }

    public int CvDatabaseAccessTokenTypeId { get; set; }

    public int FullAccessDayCount { get; set; }

    public DateTime? FullAccessExpireDate { get; set; }
}
