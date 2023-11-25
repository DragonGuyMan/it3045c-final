using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<FaveMovie> FaveMovies { get; set; }
        public DbSet<FaveSportsPlayer> FaveSportsPlayers { get; set; }
    }
}
