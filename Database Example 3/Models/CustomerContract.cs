using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerContract
{
    public long CustomerContractId { get; set; }

    public long CustomerId { get; set; }

    public int ContractTypeId { get; set; }

    public long CreateUserId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public bool IsActive { get; set; }

    public string? FileName { get; set; }

    public bool IsDeleted { get; set; }
}
