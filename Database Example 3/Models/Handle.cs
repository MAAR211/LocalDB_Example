using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Handle
{
    public long HandleId { get; set; }

    public int EntityTypeId { get; set; }

    public long? EntityId { get; set; }

    public long? ParentHandleId { get; set; }

    public long? MasterHandleId { get; set; }

    public long? HeadHandleId { get; set; }

    public int HandleStatusId { get; set; }

    public string? Description { get; set; }

    public DateTime InsertDate { get; set; }

    public bool IsLocked { get; set; }

    public DateTime? LockDate { get; set; }

    public long? LockUserId { get; set; }

    public DateTime? BindDate { get; set; }

    public DateTime StatusDate { get; set; }
}
