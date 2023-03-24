using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class JobseekerLanguage
{
    public long JobseekerLanguageId { get; set; }

    public long JobseekerId { get; set; }

    public long LanguageProficiencyLevelId { get; set; }

    public long WorldLanguageId { get; set; }

    public long? JobseekerFileId { get; set; }

    public DateTime? CreateDate { get; set; }
}
