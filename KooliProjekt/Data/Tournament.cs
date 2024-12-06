using System;
using System.Collections.Generic;

public class Tournament
{
    public int TournamentID { get; set; }    // Primary Key
    public string TournamentName { get; set; } // Name of the tournament
    public DateTime StartDate { get; set; }   // Start Date of the tournament
    public DateTime EndDate { get; set; }     // End Date of the tournament
    public List<Match> Matches { get; set; }  // Navigation Property: Tournament can have many Matches
}
