using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        // Example usage
        Player player1 = new() { PlayerID = 1, PlayerName = "John Doe", Age = 25, Position = "Forward", TeamName = "Team A" };
        Player player2 = new() { PlayerID = 2, PlayerName = "Jane Smith", Age = 28, Position = "Midfielder", TeamName = "Team B" };

        Team teamA = new() { TeamID = 1, TeamName = "Team A", Coach = "Coach A", Players = new List<Player> { player1 } };
        Team teamB = new() { TeamID = 2, TeamName = "Team B", Coach = "Coach B", Players = new List<Player> { player2 } };

        Match match1 = new() { MatchID = 1, MatchDate = DateTime.Now, TeamA = teamA, TeamB = teamB, Result = "1-0" };

        Tournament tournament = new() { TournamentID = 1, TournamentName = "Champions League", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(30), Matches = new List<Match> { match1 } };

        User user1 = new() { UserID = 1, UserName = "Admin", Email = "admin@example.com", Role = "Administrator" };

        Prediction prediction1 = new()
        {
            PredictionID = 1,
            User = user1,
            Match = match1,
            TeamAPrediction = "Win",
            TeamBPrediction = "Lose",
            PredictionDate = DateTime.Now,
            Points = 10
        };
    }
}