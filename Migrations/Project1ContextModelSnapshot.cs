﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(Project1Context))]
    partial class Project1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Project1.Models.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("Project1.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("Project1.Models.Draws", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrawsNumber");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Draws");
                });

            modelBuilder.Entity("Project1.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Project1.Models.Losses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LossesNumber");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Losses");
                });

            modelBuilder.Entity("Project1.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.Property<int>("Surname");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Project1.Models.Points", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberOfPoints");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Project1.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TeamId");

                    b.Property<int>("TeamPosition");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Project1.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Project1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project1.Models.Wins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TeamId");

                    b.Property<int>("WinssNumber");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Wins");
                });

            modelBuilder.Entity("Project1.Models.Budget", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Coach", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Draws", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany("Draws")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.League", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Losses", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany("Losses")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Player", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Points", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Position", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Project1.Models.Wins", b =>
                {
                    b.HasOne("Project1.Models.Team", "Team")
                        .WithMany("Wins")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
