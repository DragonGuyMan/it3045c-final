using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, Name = "Peter McCartney", Birthdate = new(1995, 6, 12), CollegeProgram = "CECH", ProgramYear = "Pre-Junior" },
                new TeamMember { Id = 2, Name = "Cory Allen", Birthdate = new(2003, 7, 4), CollegeProgram = "CECH", ProgramYear = "Pre-Junior" },
                new TeamMember { Id = 3, Name = "Kwasi Amponsah", Birthdate = new(1997, 11, 23), CollegeProgram = "CECH", ProgramYear = "Pre-Junior" },
                new TeamMember { Id = 4, Name = "Somyani Ghimire", Birthdate = new(2002, 2, 25), CollegeProgram = "CECH", ProgramYear = "Pre-Junior" },
                new TeamMember { Id = 5, Name = "Austin Schnee", Birthdate = new(2001, 3, 8), CollegeProgram = "CECH", ProgramYear = "Pre-Junior" }
                );

            builder.Entity<Job>().HasData(
                new Job { Id = 1, TeamMemberName = "Cory Allen", CollegeMajor = "IT", FirstJob = "McDonald's", DreamJob = "Game Developer" },
                new Job { Id = 2, TeamMemberName = "Peter McCartney", CollegeMajor = "IT", FirstJob = "Home Depot", DreamJob = "Software Developer" },
                new Job { Id = 3, TeamMemberName = "Kwasi Amponsah", CollegeMajor = "IT", FirstJob = "Honda", DreamJob = "Software Developer" },
                new Job { Id = 4, TeamMemberName = "Austin Schnee", CollegeMajor = "IT", FirstJob = null, DreamJob = "Software Developer" },
                new Job { Id = 5, TeamMemberName = "Somyani Ghimire", CollegeMajor = "IT", FirstJob = null, DreamJob = "Software Developer" }
                );

            builder.Entity<FaveMovie>().HasData(
                new FaveMovie { Id = 1, TeamMemberName = "Cory Allen", Title = "Ponyo", Genre = "Fantasy", ReleaseDate = new(2008, 7, 19) },
                new FaveMovie { Id = 2, TeamMemberName = "Peter McCartney", Title = "Interstellar", Genre = "Science Fiction", ReleaseDate = new(2014, 10, 26) },
                new FaveMovie { Id = 3, TeamMemberName = "Kwasi Amponsah", Title = "Shutter Island", Genre = "Mystery", ReleaseDate = new(2010, 2, 19) },
                new FaveMovie { Id = 4, TeamMemberName = "Austin Schnee", Title = "Spider-Man", Genre = "Superhero", ReleaseDate = new(2002, 5, 3) },
                new FaveMovie { Id = 5, TeamMemberName = "Somyani Ghimire", Title = "Iron Man", Genre = "Superhero", ReleaseDate = new(2008, 5, 2) }
                );

            builder.Entity<FaveSportsPlayer>().HasData(
                new FaveSportsPlayer { Id = 1, TeamMemberName = "Somyani Ghimire", PlayerName = "Ma Long", Sport = "Table Tennis", ChampionshipNum = 27 },
                new FaveSportsPlayer { Id = 2, TeamMemberName = "Kwasi Amponsah", PlayerName = "Kirk Cousins", Sport = "Football", ChampionshipNum = 0 },
                new FaveSportsPlayer { Id = 3, TeamMemberName = "Cory Allen", PlayerName = "Babe Ruth", Sport = "Baseball", ChampionshipNum = 7 },
                new FaveSportsPlayer { Id = 4, TeamMemberName = "Peter McCartney", PlayerName = "Timo Boll", Sport = "Table Tennis", ChampionshipNum = 15 },
                new FaveSportsPlayer { Id = 5, TeamMemberName = "Austin Schnee", PlayerName = "Lionel Messi", Sport = "Soccer", ChampionshipNum = 10 }
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<FaveMovie> FaveMovies { get; set; }
        public DbSet<FaveSportsPlayer> FaveSportsPlayers { get; set; }
    }
}
