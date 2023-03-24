using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class Account
{
    public long AccountId { get; set; }

    public long CustomerId { get; set; }

    public int AccountStatusId { get; set; }

    public int? PaymentMethodId { get; set; }

    public int? VatstatusId { get; set; }

    public decimal CreditLimit { get; set; }

    public decimal Balance { get; set; }

    public decimal AvailableAmount { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }
}
