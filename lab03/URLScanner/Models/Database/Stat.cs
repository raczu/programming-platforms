using System;
using System.Collections.Generic;

namespace URLScanner.Models.Database;

public partial class Stat
{
    public int Id { get; set; }

    public int Malicious { get; set; }

    public int Suspicious { get; set; }

    public int Undetected { get; set; }

    public int Harmless { get; set; }

    public int Timeout { get; set; }

    public virtual ICollection<Analysis> Analyses { get; set; } = new List<Analysis>();
}
