using System;
using System.Collections.Generic;

namespace URLScanner.Models.Database;

public partial class Result
{
    public int Id { get; set; }

    public string Method { get; set; } = null!;

    public string Engine { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Outcome { get; set; } = null!;

    public virtual ICollection<Analysis> Analyses { get; set; } = new List<Analysis>();
}
