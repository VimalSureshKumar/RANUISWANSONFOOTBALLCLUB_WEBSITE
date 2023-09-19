﻿using System;
using System.Collections.Generic;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;

public partial class Position
{
    public int PositionId { get; set; }

    public string Position_Name { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}