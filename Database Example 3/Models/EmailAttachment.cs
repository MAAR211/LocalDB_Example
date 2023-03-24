using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailAttachment
{
    public long EmailAttachmentId { get; set; }

    public long EmailMessageId { get; set; }

    public string AttachmentFileId { get; set; } = null!;

    public string AttachmentName { get; set; } = null!;
}
