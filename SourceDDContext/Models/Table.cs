using System;
using System.Collections.Generic;

namespace SourceDDContext.Models;

public partial class Table
{
    public string TableSchema { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public int? RowCount { get; set; }

    public int? ColCount { get; set; }

    public string? DestinationTable { get; set; }

    public string? XStgTable { get; set; }

    public string? Description { get; set; }

    public bool? NeedsMigration { get; set; }

    public virtual ICollection<Column> Columns { get; set; } = new List<Column>();
}
