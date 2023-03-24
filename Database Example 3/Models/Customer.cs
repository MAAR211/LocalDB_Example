using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Customer
{
    public long CustomerId { get; set; }

    public int CustomerTypeId { get; set; }

    public int CustomerStatusId { get; set; }

    public string IdNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Name2 { get; set; }

    public string? LegalName { get; set; }

    public string? LegalAddress { get; set; }

    public string? LegalAddress2 { get; set; }

    public int? LocalityId { get; set; }

    public string? Postcode { get; set; }

    public int? IndustryId { get; set; }

    public string? Website { get; set; }

    public string? PublicEmail { get; set; }

    public string? Description { get; set; }

    public string? Description2 { get; set; }

    public int? NumberOfEmployeesFrom { get; set; }

    public int? NumberOfEmployeesTo { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime InsertDate { get; set; }

    public long InsertUserId { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public long? LastChangeUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public long? UpdateUserId { get; set; }

    public bool IsVerified { get; set; }

    public DateTime? VerificationExpireDate { get; set; }

    public string? LegacyContactInfo { get; set; }

    public string? VideoUrl { get; set; }

    public DateTime? LastAutomaticEmailSendDate { get; set; }

    public DateTime? NextDebtRemindDate { get; set; }

    public bool HasFeeds { get; set; }

    public DateTime? InactiveDate { get; set; }

    public long? InactiveUserId { get; set; }
}
