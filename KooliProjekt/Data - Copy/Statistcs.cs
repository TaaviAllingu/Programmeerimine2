using System;
using System.Collections.Generic;
public class Statistics
{
    public int StatisticsID { get; set; }    // Primary Key
    public int PlayerID { get; set; }         // Foreign Key referencing Player
    public Player Player { get; set; }        // Navigation Property to Player
    public int GoalsScored { get; set; }     // Total goals scored by the player
    public int Assists { get; set; }         // Total assists made by the player
    public int MatchesPlayed { get; set; }   // Number of matches played by the player
    public int YellowCards { get; set; }     // Number of yellow cards received
    public int RedCards { get; set; }        // Number of red cards received
}
