using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class ReportType
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
