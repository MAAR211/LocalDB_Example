using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailContent
{
    public int EmailContentId { get; set; }

    public string ContentBody { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
