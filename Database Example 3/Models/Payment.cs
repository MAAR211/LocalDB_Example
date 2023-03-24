using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Payment
{
    public long PaymentId { get; set; }

    public string Code { get; set; } = null!;

    public long PayerAccountId { get; set; }

    public DateTime PaymentDate { get; set; }

    public DateTime CreateDate { get; set; }

    public long CreateUserId { get; set; }

    public long PaymentChannelId { get; set; }

    public decimal Amount { get; set; }

    public decimal OriginalAmount { get; set; }

    public bool IsDeleted { get; set; }

    public decimal AmountLeft { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public long? LastModifiedUserId { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public DateTime? LastAmountEditDate { get; set; }

    public long? LastAmountEditUserId { get; set; }

    public string? Comment { get; set; }
}
