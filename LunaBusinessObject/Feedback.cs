using System;
using System.Collections.Generic;

namespace LunaBusinessObject;

public partial class Feedback
{
    public string? Message { get; set; }

    public int OrderId { get; set; }

    public string Id { get; set; } = null!;

    public bool? Show { get; set; }

    public virtual AspNetUser IdNavigation { get; set; } = null!;

    public virtual HotelOrder Order { get; set; } = null!;
}
