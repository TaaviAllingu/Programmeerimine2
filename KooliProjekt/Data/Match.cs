using System;
using System.Collections.Generic;

public class Match
{
    public int MatchID { get; set; }          // Primary Key
    public int TeamAID { get; set; }          // Foreign Key referencing Team A
    public int TeamBID { get; set; }          // Foreign Key referencing Team B
    public Team TeamA { get; set; }           // Navigation Property to Team A
    public Team TeamB { get; set; }           // Navigation Property to Team B
    public DateTime MatchDate { get; set; }   // Date and Time of the match
    public string Result { get; set; }        // Result of the match (e.g., "3-2", "draw")
    public int TournamentID { get; set; }     // Foreign Key referencing Tournament
    public Tournament Tournament { get; set; } // Navigation Property to Tournament
    public List<Prediction> Predictions { get; set; } // Navigation Property: Match can have many Predictions
}
