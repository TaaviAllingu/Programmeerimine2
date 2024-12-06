using KooliProjekt.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    // DbSets for each entity in the database
    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Prediction> Predictions { get; set; }
    public DbSet<Statistics> Statistics { get; set; }

    // Constructor to pass options to the base DbContext class
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Configure the relationships between the entities
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Player and Team: One-to-many relationship (One Team has many Players)
        modelBuilder.Entity<Player>()
            .HasOne(p => p.Team)          // Player has one Team
            .WithMany(t => t.Players)     // Team has many Players
            .HasForeignKey(p => p.TeamID) // Foreign key on Player table
            .OnDelete(DeleteBehavior.Cascade); // Optional: specify delete behavior

        // Match and Tournament: One-to-many relationship (One Tournament has many Matches)
        modelBuilder.Entity<Match>()
            .HasOne(m => m.Tournament)   // Match belongs to one Tournament
            .WithMany(t => t.Matches)    // Tournament has many Matches
            .HasForeignKey(m => m.TournamentID)  // Foreign key on Match table
            .OnDelete(DeleteBehavior.Cascade); // Optional: specify delete behavior

        // Prediction and Match: One-to-many relationship (One Match can have many Predictions)
        modelBuilder.Entity<Prediction>()
            .HasOne(p => p.Match)         // Prediction is for one Match
            .WithMany(m => m.Predictions) // Match can have many Predictions
            .HasForeignKey(p => p.MatchID); // Foreign key on Prediction table

        // Player and Statistics: One-to-one relationship (One Player has one Statistics entry)
        modelBuilder.Entity<Statistics>()
            .HasOne(s => s.Player)          // Statistics belongs to one Player
            .WithOne(p => p.Statistics)     // Player has one Statistics entry
            .HasForeignKey<Statistics>(s => s.PlayerID); // Foreign key on Statistics table

        // Optional: Configure composite key for Prediction (UserID + MatchID)
        modelBuilder.Entity<Prediction>()
            .HasKey(p => new { p.UserID, p.MatchID });  // Composite key for Prediction

        // Optional: Index on PlayerName (e.g., to make sure it's unique)
        modelBuilder.Entity<Player>()
            .HasIndex(p => p.PlayerName)
            .IsUnique();  // Ensure PlayerName is unique

        // Optional: Seed initial data (example for Team table)
        modelBuilder.Entity<Team>().HasData(
            new Team { TeamID = 1, TeamName = "Team A", Coach = "Coach A" },
            new Team { TeamID = 2, TeamName = "Team B", Coach = "Coach B" }
        );
    }
}

