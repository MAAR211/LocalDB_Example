using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerAutomaticEmail
{
    public long CustomerAutomaticEmailId { get; set; }

    public long CustomerId { get; set; }

    public long CustomerAgentId { get; set; }

    public int EmailTypeId { get; set; }

    public long TemplateId { get; set; }

    public DateTime SendDate { get; set; }
}
