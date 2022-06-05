﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tennis_Competitions.Data.Context;

#nullable disable

namespace Tennis_Competitions.Data.Migrations
{
    [DbContext(typeof(TennisCompetitionsDBContext))]
    partial class TennisCompetitionsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AcesFirstPlayer")
                        .HasColumnType("int");

                    b.Property<int>("AcesSecondPlayer")
                        .HasColumnType("int");

                    b.Property<int>("DoubleFoultsFirstPlayer")
                        .HasColumnType("int");

                    b.Property<int>("DoubleFoultsSecondPlayer")
                        .HasColumnType("int");

                    b.Property<Guid>("FirstPlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstPlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPlayerResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Round")
                        .HasColumnType("int");

                    b.Property<Guid>("SecondPlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecondPlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPlayerResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UnforcesErrorsFirstPlayer")
                        .HasColumnType("int");

                    b.Property<int>("UnforcesErrorsSecondPlayer")
                        .HasColumnType("int");

                    b.Property<int>("WinnersFirstPlayer")
                        .HasColumnType("int");

                    b.Property<int>("WinnersSecondPlayer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74c47f54-6175-4f57-af59-590ba981a51c"),
                            AcesFirstPlayer = 23,
                            AcesSecondPlayer = 11,
                            DoubleFoultsFirstPlayer = 5,
                            DoubleFoultsSecondPlayer = 9,
                            FirstPlayerId = new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                            FirstPlayerName = "Roger Federer",
                            FirstPlayerResult = "6,7,3,7",
                            Name = "Men's Singles Court Philippe-Chatrier-Final",
                            Round = 6,
                            SecondPlayerId = new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                            SecondPlayerName = "Rafael Nadal",
                            SecondPlayerResult = "4,5,6,5",
                            UnforcesErrorsFirstPlayer = 35,
                            UnforcesErrorsSecondPlayer = 22,
                            WinnersFirstPlayer = 48,
                            WinnersSecondPlayer = 33
                        });
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Loses")
                        .HasColumnType("int");

                    b.Property<Guid?>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TournamentsWins")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                            FirstName = "Roger",
                            LastName = "Federer",
                            Loses = 275,
                            TournamentsWins = 0,
                            Wins = 1251
                        },
                        new
                        {
                            Id = new Guid("875e07ad-5274-4f96-91c5-bbc41fd41804"),
                            FirstName = "Novak",
                            LastName = "Djokovic",
                            Loses = 203,
                            TournamentsWins = 0,
                            Wins = 1001
                        },
                        new
                        {
                            Id = new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                            FirstName = "Rafael",
                            LastName = "Nadal",
                            Loses = 212,
                            TournamentsWins = 0,
                            Wins = 1051
                        },
                        new
                        {
                            Id = new Guid("284b35af-d4cc-4fe1-8773-7f56facc508a"),
                            FirstName = "Grigor",
                            LastName = "Dimitrov",
                            Loses = 240,
                            TournamentsWins = 0,
                            Wins = 361
                        });
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.PlayerMatch", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerId", "MatchId");

                    b.HasIndex("MatchId");

                    b.ToTable("PlayerMatches");

                    b.HasData(
                        new
                        {
                            PlayerId = new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                            MatchId = new Guid("74c47f54-6175-4f57-af59-590ba981a51c")
                        },
                        new
                        {
                            PlayerId = new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                            MatchId = new Guid("74c47f54-6175-4f57-af59-590ba981a51c")
                        });
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.PlayerTournament", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerId", "TournamentId");

                    b.HasIndex("TournamentId");

                    b.ToTable("PlayerTournament");

                    b.HasData(
                        new
                        {
                            PlayerId = new Guid("076bee1c-3b59-4fe4-8a14-6ce21ca55b53"),
                            TournamentId = new Guid("34405d3b-5831-41d8-8609-477a173f97e9")
                        },
                        new
                        {
                            PlayerId = new Guid("1eabd820-90bc-42a8-9fc4-08bbcbbd0cf1"),
                            TournamentId = new Guid("34405d3b-5831-41d8-8609-477a173f97e9")
                        });
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Tournament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("918460a2-6666-4bf4-97d4-ade394b9ba2e"),
                            Name = "Roland-Garros",
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("34405d3b-5831-41d8-8609-477a173f97e9"),
                            Name = "WIMBLEDON",
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("57e6e345-fb55-4cc1-b5f2-f9123001ab0c"),
                            Name = "US Open",
                            Surface = 2
                        },
                        new
                        {
                            Id = new Guid("98de58dd-99ed-4647-95bc-cf0147c0d125"),
                            Name = "Australian Open",
                            Surface = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Match", b =>
                {
                    b.HasOne("Tennis_Competitions.Data.Models.Tournament", null)
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Player", b =>
                {
                    b.HasOne("Tennis_Competitions.Data.Models.Match", null)
                        .WithMany("Players")
                        .HasForeignKey("MatchId");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.PlayerMatch", b =>
                {
                    b.HasOne("Tennis_Competitions.Data.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tennis_Competitions.Data.Models.Player", "Player")
                        .WithMany("PlayerMatches")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.PlayerTournament", b =>
                {
                    b.HasOne("Tennis_Competitions.Data.Models.Player", "Player")
                        .WithMany("Tournaments")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tennis_Competitions.Data.Models.Tournament", "Tournament")
                        .WithMany("Players")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Match", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Player", b =>
                {
                    b.Navigation("PlayerMatches");

                    b.Navigation("Tournaments");
                });

            modelBuilder.Entity("Tennis_Competitions.Data.Models.Tournament", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
