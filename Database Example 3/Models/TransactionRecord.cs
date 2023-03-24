using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TransactionRecord
{
    public long TransactionRecordId { get; set; }

    public string? Code { get; set; }

    public DateTime CreateDate { get; set; }

    public long OriginalPayerAccountId { get; set; }

    public long PayerAccountId { get; set; }

    public int OriginalPaymentMethodId { get; set; }

    public int PaymentMethodId { get; set; }

    public long OriginalOrderId { get; set; }

    public long OrderId { get; set; }

    public long? SalesCustomerPortfolioAccountManagerId { get; set; }

    public string? OriginalProFormaInvoiceFileId { get; set; }

    public string? ProFormaInvoiceFileId { get; set; }

    public long? InitialPartialApproveUserId { get; set; }

    public DateTime? InitialPartialApproveDate { get; set; }

    public long? InitialCompleteApproveUserId { get; set; }

    public DateTime? InitialCompleteApproveDate { get; set; }

    public long? FinalApproveUserId { get; set; }

    public DateTime? FinalApproveDate { get; set; }

    public decimal OrderTotalAmount { get; set; }

    public decimal TaxesTotalAmount { get; set; }

    public bool IsTaxFree { get; set; }

    public decimal InvoiceTotalAmount { get; set; }

    public int ApprovalStatusId { get; set; }

    public int TransactionStatusId { get; set; }

    public long? LastModifiedUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public DateTime? LastOrderEditDate { get; set; }

    public long? LastOrderEditUserId { get; set; }

    public long? LastOrderTotalAmountWithDiscountEditUserId { get; set; }

    public DateTime? LastOrderTotalAmountWithDiscountEditDate { get; set; }

    public long? LastPayerEditUserId { get; set; }

    public DateTime? LastPayerEditDate { get; set; }

    public long CreateUserId { get; set; }

    public bool IsProFormaInvoiceSent { get; set; }

    public DateTime? ProFormaInvoiceSendDate { get; set; }

    public long? ProFormaInvoiceSendUserId { get; set; }

    public string? LastSendProformaInvoiceFileId { get; set; }

    public decimal OrderTotalAmountWithDiscount { get; set; }

    public long? CancelUserId { get; set; }

    public DateTime? CancelDate { get; set; }

    public long? RejectUserId { get; set; }

    public DateTime? RejectDate { get; set; }

    public long? ReverseUserId { get; set; }

    public DateTime? ReverseDate { get; set; }

    public long? InvoiceId { get; set; }

    public bool? IsConfirmationEmailSent { get; set; }

    public DateTime? ConfirmationEmailSendDate { get; set; }
}
