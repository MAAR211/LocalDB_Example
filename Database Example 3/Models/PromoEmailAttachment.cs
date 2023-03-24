using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PromoEmailAttachment
{
    public long PromoEmailAttachmentId { get; set; }

    public long PromoEmailTemplateId { get; set; }

    public string Filename { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
