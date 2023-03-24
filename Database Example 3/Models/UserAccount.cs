using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class UserAccount
{
    public long UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public string? DisplayName { get; set; }

    public int UserTypeId { get; set; }

    public int UserStatusId { get; set; }

    public string? Email { get; set; }

    public bool IsPasswordChangeRequired { get; set; }

    public DateTime? LastVisitDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public int? OriginWebsiteId { get; set; }

    public bool IsEmailVerified { get; set; }

    public int? MigratedFromOriginWebsiteId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public string? EmailVerificationResendToken { get; set; }

    public int EmailVerificationResendAttempts { get; set; }

    public string LanguageId { get; set; } = null!;
}
