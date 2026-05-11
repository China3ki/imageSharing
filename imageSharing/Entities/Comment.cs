using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class Comment
{
    public int Id { get; set; }

    public int? ImageId { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public virtual Image? Image { get; set; }

    public virtual User? User { get; set; }
}
