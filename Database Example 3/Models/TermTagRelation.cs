using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class TermTagRelation
{
    public int TermTagRelationId { get; set; }

    public int TermTagId { get; set; }

    public int RelatedTermTagId { get; set; }

    public double RelationWeight { get; set; }

    public bool IsActive { get; set; }
}
