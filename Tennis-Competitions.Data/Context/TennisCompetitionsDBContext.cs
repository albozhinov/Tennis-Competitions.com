namespace Tennis_Competitions.Data.Context
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Tennis_Competitions.Data.Models;

    public class TennisCompetitionsDBContext : IdentityDbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<PlayerMatch> PlayerMatches { get; set; }

        public DbSet<TournamentMatch> TournamentMatches { get; set; }


        public TennisCompetitionsDBContext()
        {

        }

        public TennisCompetitionsDBContext(DbContextOptions<TennisCompetitionsDBContext> options)
            : base(options)
        {

        }

        private void LoadJsonInDB(ModelBuilder builder)
        {
            try
            {
                var tournamentsAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\tournaments.json");
                var playersAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\players.json");
                var matchesAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\matches.json");
                var playerMatchAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\playermatch.json");
                var playerTournamentAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\playertournament.json");
                var tournamentMatchAsJson = File.ReadAllText(@"..\Tennis-Competitions.Data\Jsons\tournamentmatch.json");


                var tournaments = JsonConvert.DeserializeObject<Tournament[]>(tournamentsAsJson);
                var players = JsonConvert.DeserializeObject<Player[]>(playersAsJson);
                var matches = JsonConvert.DeserializeObject<Match[]>(matchesAsJson);
                var playerMatches = JsonConvert.DeserializeObject<PlayerMatch[]>(playerMatchAsJson);
                var playerTournaments = JsonConvert.DeserializeObject<PlayerTournament[]>(playerTournamentAsJson);
                var tournamentMatches = JsonConvert.DeserializeObject<TournamentMatch[]>(tournamentMatchAsJson);


                builder.Entity<Tournament>().HasData(tournaments);
                builder.Entity<Player>().HasData(players);
                builder.Entity<Match>().HasData(matches);
                builder.Entity<PlayerMatch>().HasData(playerMatches);
                builder.Entity<PlayerTournament>().HasData(playerTournaments);
                builder.Entity<TournamentMatch>().HasData(tournamentMatches);


            }
            catch (Exception)
            {
                return;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            LoadJsonInDB(builder);

            builder.Entity<PlayerMatch>()
                            .HasKey(pm => new { pm.PlayerId, pm.MatchId });

            builder.Entity<PlayerTournament>()
                            .HasKey(pt => new { pt.PlayerId, pt.TournamentId });

            builder.Entity<TournamentMatch>().HasKey(tm => new { tm.MatchId, tm.TournamentId });

            base.OnModelCreating(builder);
        }
    }
}
