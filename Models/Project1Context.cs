using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Project1Context : DbContext
    {
        private string _conStr;
        public Project1Context () : base()
        {
            _conStr = "User ID=postgres; Password=1234; Server=localhost; Port=5432; Database=InMotionDatabase; Integrated Security=true; Pooling=true;";
        }
        public Project1Context(DbContextOptions<Project1Context> options) : base(options)
        {

        }
        public Project1Context(string conStr)
        {
            _conStr = conStr;
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Points> Points { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Wins> Wins { get; set; }
        public DbSet<Draws> Draws { get; set; }
        public DbSet<Losses> Losses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres; Password=1234; Server=localhost; Port=5432; Database=InMotionDatabase; Integrated Security=true; Pooling=true;");
        }
    }
}
