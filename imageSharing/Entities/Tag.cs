using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class Tag
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
