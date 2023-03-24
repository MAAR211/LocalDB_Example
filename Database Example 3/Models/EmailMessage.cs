using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailMessage
{
    public long EmailMessageId { get; set; }

    public string FromAddress { get; set; } = null!;

    public string FromTitle { get; set; } = null!;

    public string? ToAddress { get; set; }

    public string? Ccaddress { get; set; }

    public string? Bccaddress { get; set; }

    public string Subject { get; set; } = null!;

    public long? EmailContentId { get; set; }

    public int EmailStatusId { get; set; }

    public int? DeliveryFailureId { get; set; }

    public int DeliveryAttemptCount { get; set; }

    public short Priority { get; set; }

    public string? TemplatKeyName { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public DateTime? PlannedSendDate { get; set; }

    public bool? IsTemporary { get; set; }

    public string? Tags { get; set; }

    public int EmailTypeId { get; set; }

    public DateTime? SendDate { get; set; }
}
