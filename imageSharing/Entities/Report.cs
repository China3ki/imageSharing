using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class Report
{
    public int Id { get; set; }

    public int ImageId { get; set; }

    public int UserId { get; set; }

    public int TypeId { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual ReportType Type { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
