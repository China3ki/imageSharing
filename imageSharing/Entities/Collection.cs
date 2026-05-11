using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class Collection
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
