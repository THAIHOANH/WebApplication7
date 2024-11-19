using System;
using System.Collections.Generic;

namespace GroupFinder.Models;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? LeaderId { get; set; }

    public virtual User? Leader { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
