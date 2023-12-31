﻿// <auto-generated />
using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20231126191820_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Models.FaveMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamMemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FaveMovies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Fantasy",
                            ReleaseDate = new DateTime(2008, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamMemberName = "Cory Allen",
                            Title = "Ponyo"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Science Fiction",
                            ReleaseDate = new DateTime(2014, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamMemberName = "Peter McCartney",
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Mystery",
                            ReleaseDate = new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamMemberName = "Kwasi Amponsah",
                            Title = "Shutter Island"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Superhero",
                            ReleaseDate = new DateTime(2002, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamMemberName = "Austin Schnee",
                            Title = "Spider-Man"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Superhero",
                            ReleaseDate = new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamMemberName = "Somyani Ghimire",
                            Title = "Iron Man"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.FaveSportsPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChampionshipNum")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamMemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FaveSportsPlayers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChampionshipNum = 27,
                            PlayerName = "Ma Long",
                            Sport = "Table Tennis",
                            TeamMemberName = "Somyani Ghimire"
                        },
                        new
                        {
                            Id = 2,
                            ChampionshipNum = 0,
                            PlayerName = "Kirk Cousins",
                            Sport = "Football",
                            TeamMemberName = "Kwasi Amponsah"
                        },
                        new
                        {
                            Id = 3,
                            ChampionshipNum = 7,
                            PlayerName = "Babe Ruth",
                            Sport = "Baseball",
                            TeamMemberName = "Cory Allen"
                        },
                        new
                        {
                            Id = 4,
                            ChampionshipNum = 15,
                            PlayerName = "Timo Boll",
                            Sport = "Table Tennis",
                            TeamMemberName = "Peter McCartney"
                        },
                        new
                        {
                            Id = 5,
                            ChampionshipNum = 10,
                            PlayerName = "Lionel Messi",
                            Sport = "Soccer",
                            TeamMemberName = "Austin Schnee"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CollegeMajor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DreamJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamMemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CollegeMajor = "IT",
                            DreamJob = "Game Developer",
                            FirstJob = "McDonald's",
                            TeamMemberName = "Cory Allen"
                        },
                        new
                        {
                            Id = 2,
                            CollegeMajor = "IT",
                            DreamJob = "Software Developer",
                            FirstJob = "Home Depot",
                            TeamMemberName = "Peter McCartney"
                        },
                        new
                        {
                            Id = 3,
                            CollegeMajor = "IT",
                            DreamJob = "Software Developer",
                            FirstJob = "Honda",
                            TeamMemberName = "Kwasi Amponsah"
                        },
                        new
                        {
                            Id = 4,
                            CollegeMajor = "IT",
                            DreamJob = "Software Developer",
                            TeamMemberName = "Austin Schnee"
                        },
                        new
                        {
                            Id = 5,
                            CollegeMajor = "IT",
                            DreamJob = "Software Developer",
                            TeamMemberName = "Somyani Ghimire"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1995, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "CECH",
                            Name = "Peter McCartney",
                            ProgramYear = "Pre-Junior"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2003, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "CECH",
                            Name = "Cory Allen",
                            ProgramYear = "Pre-Junior"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "CECH",
                            Name = "Kwasi Amponsah",
                            ProgramYear = "Pre-Junior"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(2002, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "CECH",
                            Name = "Somyani Ghimire",
                            ProgramYear = "Pre-Junior"
                        },
                        new
                        {
                            Id = 5,
                            Birthdate = new DateTime(2001, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "CECH",
                            Name = "Austin Schnee",
                            ProgramYear = "Pre-Junior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
