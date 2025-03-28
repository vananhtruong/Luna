using System;
using System.Collections.Generic;

namespace LunaBusinessObject;

public partial class ChatMessage
{
    public int Id { get; set; }

    public string? SenderId { get; set; }

    public string? ReceiverId { get; set; }

    public string? Message { get; set; }

    public DateTime? Timestamp { get; set; }

    public bool? IsSeen { get; set; }

    public virtual AspNetUser? Receiver { get; set; }

    public virtual AspNetUser? Sender { get; set; }
}
