using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class OccupationCategory
{
    public int OccupationCategoryId { get; set; }

    public int HeadOccupationCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public string KeyName { get; set; } = null!;
}
