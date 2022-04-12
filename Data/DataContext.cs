﻿using Microsoft.EntityFrameworkCore;
using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobAd> JobAds { get; set; }

        public DbSet<UserLike> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserLike>()
                .HasKey(k => new { k.SourceUserId, k.JobAdId });
           
            builder.Entity<UserLike>()
                .HasOne(s => s.SourceUser)
                .WithMany(j => j.LikedJobAds)
                .HasForeignKey(s => s.SourceUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
