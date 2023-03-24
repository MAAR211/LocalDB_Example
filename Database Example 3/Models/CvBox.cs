using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvBox
{
    public long CvBoxId { get; set; }

    public long CustomerId { get; set; }

    public bool IsActive { get; set; }
}
