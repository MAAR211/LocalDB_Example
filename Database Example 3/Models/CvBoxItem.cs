using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CvBoxItem
{
    public long CvBoxItemId { get; set; }

    public long CvBoxId { get; set; }

    public long JobseekerId { get; set; }

    public long CvBoxAccessTokenId { get; set; }

    public DateTime SendDate { get; set; }

    public int StatusId { get; set; }
}
