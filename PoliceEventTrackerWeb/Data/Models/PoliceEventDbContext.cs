using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoliceEventTrackerWeb.Domain.Models;
using PoliceEventTrackerWeb.Domain.Other;

namespace PoliceEventTrackerWeb.Data.Models
{
    public class PoliceEventDbContext : DbContext
    {
        public PoliceEventDbContext()
        {
        }
        public PoliceEventDbContext(ApplicationSettings settings)
        {
            applicationSettings = settings;
        }
        public PoliceEventDbContext(DbContextOptions<PoliceEventDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Update> Updates { get; set; }

        private ApplicationSettings applicationSettings;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(applicationSettings.DbConnection);
            }

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
