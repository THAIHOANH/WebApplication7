using System;
using System.Collections.Generic;

namespace GroupFinder.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public int? GroupId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Group? Group { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
