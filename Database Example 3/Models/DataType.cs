﻿using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class DataType
{
    public int DataTypeId { get; set; }

    public string KeyName { get; set; } = null!;

    public string Name { get; set; } = null!;
}
