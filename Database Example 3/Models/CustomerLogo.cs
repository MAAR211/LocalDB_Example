using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class CustomerLogo
{
    public long CustomerLogoId { get; set; }

    public long CustomerId { get; set; }

    public string LogoFilename { get; set; } = null!;

    public string LogoThumbnail1Filename { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public bool IsUpdatingRequired { get; set; }
}
