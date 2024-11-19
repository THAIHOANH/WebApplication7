using System;
using System.Collections.Generic;

namespace GroupFinder.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public int? GroupId { get; set; }

    public int? UserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public virtual Group? Group { get; set; }

    public virtual User? User { get; set; }
}
