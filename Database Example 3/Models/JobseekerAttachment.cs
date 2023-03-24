using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerAttachment
{
    public long JobseekerAttachmentId { get; set; }

    public long JobseekerId { get; set; }

    public long JobseekerDocumentId { get; set; }
}
