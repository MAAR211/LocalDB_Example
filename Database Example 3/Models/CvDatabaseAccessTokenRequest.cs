using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvDatabaseAccessTokenRequest
{
    public long CvDatabaseAccessTokenRequestId { get; set; }

    public long? RequestUserId { get; set; }

    public long? RequestCustomerAgentId { get; set; }

    public long? RequestCustomerId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public long? TerminateUserId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public long? ProcessUserId { get; set; }
}
