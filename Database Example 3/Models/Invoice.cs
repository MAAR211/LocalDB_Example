using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Invoice
{
    public long InvoiceId { get; set; }

    public string Code { get; set; } = null!;

    public long SerialNumber { get; set; }

    public DateTime CreateDate { get; set; }

    public long PayerCustomerAccountId { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal Vatamount { get; set; }

    public int StatusId { get; set; }

    public bool IsApproved { get; set; }

    public int AccountingStatusId { get; set; }

    public string? InvoiceFileId { get; set; }

    public bool IsMerged { get; set; }

    public long? MergeTargetInvoiceId { get; set; }

    public long CreateUserId { get; set; }

    public long? ApproveUserId { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? PayOffDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public long? DeleteUserId { get; set; }

    public DateTime? LastStatusChangeDate { get; set; }

    public long? LastStatusChangeUserId { get; set; }

    public DateTime? ActivationDate { get; set; }

    public int InvoiceTypeId { get; set; }

    public bool IsInvoiceFileSent { get; set; }

    public DateTime? InvoiceFileSendDate { get; set; }

    public bool IsEdited { get; set; }
}
