using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TransactionInvoice
{
    public long TransactionInvoiceId { get; set; }

    public long TransactionRecordId { get; set; }

    public long InvoiceId { get; set; }
}
