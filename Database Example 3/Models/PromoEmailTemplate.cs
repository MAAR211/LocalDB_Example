using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class PromoEmailTemplate
{
    public long PromoEmailTemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public int StatusId { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? ApproveDate { get; set; }

    public long? ApproveUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsSent { get; set; }
}
