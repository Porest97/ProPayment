﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProPayment.Models;

namespace ProPayment.Migrations
{
    [DbContext(typeof(ProPaymentContext))]
    [Migration("20190427065043_SportId")]
    partial class SportId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProPayment.Models.CupOnlineMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arena");

                    b.Property<string>("AwayTeam");

                    b.Property<string>("HomeTeam");

                    b.Property<DateTime>("MatchDateTime");

                    b.Property<string>("MatchDescription");

                    b.Property<int?>("MatchNumberCupOnline");

                    b.Property<int?>("MatchNumberTSM");

                    b.Property<string>("Ref1");

                    b.Property<string>("Ref2");

                    b.Property<string>("Ref3");

                    b.Property<string>("Ref4");

                    b.Property<int?>("ScoreAwayTeam");

                    b.Property<int?>("ScoreHomeTeam");

                    b.Property<int?>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("CupOnlineMatch");
                });

            modelBuilder.Entity("ProPayment.Models.HockeyMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MatchName");

                    b.HasKey("Id");

                    b.ToTable("HockeyMatch");
                });

            modelBuilder.Entity("ProPayment.Models.MatchFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HDFee");

                    b.Property<int?>("LDFee");

                    b.Property<string>("MatchLength");

                    b.Property<string>("Series");

                    b.Property<string>("SeriesAgeGroupe");

                    b.Property<string>("SeriesCategory");

                    b.HasKey("Id");

                    b.ToTable("MatchFee");
                });

            modelBuilder.Entity("ProPayment.Models.PROMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arena");

                    b.Property<string>("AwayTeam");

                    b.Property<string>("HomeTeam");

                    b.Property<DateTime>("MatchDateTime");

                    b.Property<string>("MatchDescription");

                    b.Property<int?>("MatchNumberTSM");

                    b.Property<int?>("PROMatchNumber");

                    b.Property<string>("Ref1");

                    b.Property<string>("Ref2");

                    b.Property<string>("Ref3");

                    b.Property<string>("Ref4");

                    b.Property<int?>("RefereeId");

                    b.Property<int?>("ScoreAwayTeam");

                    b.Property<int?>("ScoreHomeTeam");

                    b.Property<int?>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("RefereeId");

                    b.HasIndex("TournamentId");

                    b.ToTable("PROMatch");
                });

            modelBuilder.Entity("ProPayment.Models.PROWorkouts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDateTime");

                    b.Property<int?>("SportId");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("Id");

                    b.HasIndex("SportId");

                    b.ToTable("PROWorkouts");
                });

            modelBuilder.Entity("ProPayment.Models.PaymentVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Alowance");

                    b.Property<string>("BankAccountNumber");

                    b.Property<int?>("Fee");

                    b.Property<int?>("FeeHD");

                    b.Property<int?>("FeeLD");

                    b.Property<int>("LateMatchStart");

                    b.Property<int?>("NumberOfAsHD");

                    b.Property<int?>("NumberOfAsLD");

                    b.Property<int?>("NumberOfMatches");

                    b.Property<string>("RefName");

                    b.Property<string>("Ssn");

                    b.Property<int?>("TotalPayment");

                    b.Property<int?>("TournamentId");

                    b.Property<int?>("TravelKost");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("PaymentVerification");
                });

            modelBuilder.Entity("ProPayment.Models.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("EMail");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("PROMatchId");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("RefNumber");

                    b.Property<string>("Ssn");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("PROMatchId");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("ProPayment.Models.RefereeFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RefereeFeeCategory");

                    b.Property<string>("RefereeFeeName");

                    b.Property<int?>("RefereeFeeValue");

                    b.HasKey("Id");

                    b.ToTable("RefereeFee");
                });

            modelBuilder.Entity("ProPayment.Models.RefereeReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HockeyMatchId");

                    b.Property<int>("RefereeFeeId");

                    b.Property<int>("RefereeId");

                    b.HasKey("Id");

                    b.HasIndex("HockeyMatchId");

                    b.HasIndex("RefereeFeeId");

                    b.HasIndex("RefereeId");

                    b.ToTable("RefereeReceipt");
                });

            modelBuilder.Entity("ProPayment.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SportName");

                    b.HasKey("Id");

                    b.ToTable("Sport");
                });

            modelBuilder.Entity("ProPayment.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TournamentName");

                    b.HasKey("Id");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("ProPayment.Models.CupOnlineMatch", b =>
                {
                    b.HasOne("ProPayment.Models.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("ProPayment.Models.PROMatch", b =>
                {
                    b.HasOne("ProPayment.Models.Referee", "Referee")
                        .WithMany()
                        .HasForeignKey("RefereeId");

                    b.HasOne("ProPayment.Models.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("ProPayment.Models.PROWorkouts", b =>
                {
                    b.HasOne("ProPayment.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");
                });

            modelBuilder.Entity("ProPayment.Models.PaymentVerification", b =>
                {
                    b.HasOne("ProPayment.Models.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("ProPayment.Models.Referee", b =>
                {
                    b.HasOne("ProPayment.Models.PROMatch")
                        .WithMany("Referees")
                        .HasForeignKey("PROMatchId");
                });

            modelBuilder.Entity("ProPayment.Models.RefereeReceipt", b =>
                {
                    b.HasOne("ProPayment.Models.HockeyMatch", "Match")
                        .WithMany()
                        .HasForeignKey("HockeyMatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProPayment.Models.RefereeFee", "RefereeFee")
                        .WithMany()
                        .HasForeignKey("RefereeFeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProPayment.Models.Referee", "Referee")
                        .WithMany()
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
