using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Session
{
    public long SessionId { get; set; }

    public Guid SessionUid { get; set; }

    public long UserId { get; set; }

    public int UserTypeId { get; set; }

    public long? UserDetailId { get; set; }

    public int? AssociatedUserTypeId { get; set; }

    public long? AssociatedUserDetailId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? AbsoluteExpirationDate { get; set; }

    public DateTime LastAccessDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? ExpirationSetDate { get; set; }

    public bool IsActive { get; set; }

    public bool? IsUserDataRefreshRequired { get; set; }
}
