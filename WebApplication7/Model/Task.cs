using System;
using System.Collections.Generic;

namespace GroupFinder.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string TaskName { get; set; } = null!;

    public int? ProjectId { get; set; }

    public int? AssignedTo { get; set; }

    public string Status { get; set; } = null!;

    public virtual User? AssignedToNavigation { get; set; }

    public virtual Project? Project { get; set; }
}
