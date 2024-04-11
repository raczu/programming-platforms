using System;
using System.Collections.Generic;

namespace URLScanner.Models.Database;

public partial class Analysis
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public DateTime Date { get; set; }

    public int StatId { get; set; }

    public virtual Stat Stat { get; set; } = null!;

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
