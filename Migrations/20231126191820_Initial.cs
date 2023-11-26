using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaveMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaveMovies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaveSportsPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampionshipNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaveSportsPlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeMajor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DreamJob = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramYear = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FaveMovies",
                columns: new[] { "Id", "Genre", "ReleaseDate", "TeamMemberName", "Title" },
                values: new object[,]
                {
                    { 1, "Fantasy", new DateTime(2008, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cory Allen", "Ponyo" },
                    { 2, "Science Fiction", new DateTime(2014, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter McCartney", "Interstellar" },
                    { 3, "Mystery", new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kwasi Amponsah", "Shutter Island" },
                    { 4, "Superhero", new DateTime(2002, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin Schnee", "Spider-Man" },
                    { 5, "Superhero", new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somyani Ghimire", "Iron Man" }
                });

            migrationBuilder.InsertData(
                table: "FaveSportsPlayers",
                columns: new[] { "Id", "ChampionshipNum", "PlayerName", "Sport", "TeamMemberName" },
                values: new object[,]
                {
                    { 1, 27, "Ma Long", "Table Tennis", "Somyani Ghimire" },
                    { 2, 0, "Kirk Cousins", "Football", "Kwasi Amponsah" },
                    { 3, 7, "Babe Ruth", "Baseball", "Cory Allen" },
                    { 4, 15, "Timo Boll", "Table Tennis", "Peter McCartney" },
                    { 5, 10, "Lionel Messi", "Soccer", "Austin Schnee" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CollegeMajor", "DreamJob", "FirstJob", "TeamMemberName" },
                values: new object[,]
                {
                    { 1, "IT", "Game Developer", "McDonald's", "Cory Allen" },
                    { 2, "IT", "Software Developer", "Home Depot", "Peter McCartney" },
                    { 3, "IT", "Software Developer", "Honda", "Kwasi Amponsah" },
                    { 4, "IT", "Software Developer", null, "Austin Schnee" },
                    { 5, "IT", "Software Developer", null, "Somyani Ghimire" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "Name", "ProgramYear" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "CECH", "Peter McCartney", "Pre-Junior" },
                    { 2, new DateTime(2003, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "CECH", "Cory Allen", "Pre-Junior" },
                    { 3, new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "CECH", "Kwasi Amponsah", "Pre-Junior" },
                    { 4, new DateTime(2002, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "CECH", "Somyani Ghimire", "Pre-Junior" },
                    { 5, new DateTime(2001, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CECH", "Austin Schnee", "Pre-Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaveMovies");

            migrationBuilder.DropTable(
                name: "FaveSportsPlayers");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
