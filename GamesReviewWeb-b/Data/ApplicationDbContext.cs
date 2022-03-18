using GamesReviewWeb_b.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesReviewWeb_b.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Game>(g => { 

                g.Property(g => g.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                g.HasOne(g => g.Publisher).WithMany(p => p.Games).HasForeignKey(g => g.PublisherId);
            });

            builder.Entity<Publisher>(p => {
                p.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
