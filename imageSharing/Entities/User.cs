using System;
using System.Collections.Generic;

namespace imageSharing.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Avatar { get; set; }

    public string? BackgroundImage { get; set; }

    public string? Description { get; set; }

    public DateOnly Date { get; set; }

    public bool Admin { get; set; }

    public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Image> ImagesNavigation { get; set; } = new List<Image>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<User> Followers { get; set; } = new List<User>();

    public virtual ICollection<User> Followings { get; set; } = new List<User>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Image> Images1 { get; set; } = new List<Image>();
}
