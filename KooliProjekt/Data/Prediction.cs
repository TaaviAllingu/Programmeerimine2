using System;
using System.Collections.Generic;
public class Prediction
{
    public int UserID { get; set; }           // Foreign Key referencing User
    public User User { get; set; }            // Navigation Property to User
    public int MatchID { get; set; }          // Foreign Key referencing Match
    public Match Match { get; set; }          // Navigation Property to Match
    public string PredictedResult { get; set; } // Predicted result (e.g., "2-1", "draw")
    public DateTime PredictionDate { get; set; } // Date when the prediction was made
    public int Points { get; set; }           // Points awarded for correct prediction
    public string TeamAPrediction { get; internal set; }
    public string TeamBPrediction { get; internal set; }
    public int PredictionID { get; internal set; }
}
