namespace Tennis_Competitions.Data.Context
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Tennis_Competitions.Data.Models;

    public class TennisCompetitionsDBContext : IdentityDbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<PlayerMatch> PlayerMatches { get; set; }


        public TennisCompetitionsDBContext()
        {

        }


        public TennisCompetitionsDBContext(DbContextOptions<TennisCompetitionsDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlayerMatch>()
                            .HasKey(pm => new { pm.PlayerId, pm.MatchId });

            builder.Entity<PlayerTournament>()
                            .HasKey(pt => new { pt.PlayerId, pt.TournamentId });

            //builder.Entity<Player>().HasMany(p => p.PlayerMatches)
            //    .WithOne(pm => pm.Player)
            //    .HasForeignKey(pm => pm.MatchId)
            //    .OnDelete(DeleteBehavior.Restrict);
                                    




            base.OnModelCreating(builder);
        }
    }
}
