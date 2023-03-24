using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailMessageRecipient
{
    public long EmailMessageRecipientId { get; set; }

    public long EmailMessageId { get; set; }

    public string Email { get; set; } = null!;

    public int EmailMessageRecipientTypeId { get; set; }

    public DateTime CreateDate { get; set; }
}
