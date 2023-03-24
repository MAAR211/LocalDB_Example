using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class EmailMessageRecipientType
{
    public int EmailMessageRecipientTypeId { get; set; }

    public string Name { get; set; } = null!;
}
