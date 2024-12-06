using System;
using System.Collections.Generic;

public class Team
{
    public int TeamID { get; set; }
    public string TeamName { get; set; }
    public string Coach { get; set; }
    public List<Player> Players { get; set; } // Navigation property to Players
}