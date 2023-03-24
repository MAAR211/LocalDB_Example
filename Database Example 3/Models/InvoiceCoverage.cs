using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class InvoiceCoverage
{
    public long InvoiceCoverageId { get; set; }

    public long InvoiceId { get; set; }

    public long PaymentId { get; set; }

    public decimal Amount { get; set; }

    public long CreateUserId { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public long? LastAmountEditUserId { get; set; }

    public DateTime? LastAmountEditDate { get; set; }
}
