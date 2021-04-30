using System;
using System.Collections.Generic;
using System.Text;
using Kursach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Data
{
    public class CampaignDbContext : DbContext
    {
        public CampaignDbContext(DbContextOptions<CampaignDbContext> options)
            : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>().ToTable("Campaign");
        }
    }
}
