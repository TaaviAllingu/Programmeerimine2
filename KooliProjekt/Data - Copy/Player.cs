using System;
using System.Collections.Generic;

public class Player
{
    public int PlayerID { get; set; }
    public string PlayerName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int TeamID { get; set; } // Foreign key to Team
    public Team Team { get; set; }  // Navigation property to Team
    public Statistics Statistics { get; set; } // Navigation to Statistics
    public string TeamName { get; internal set; }
}