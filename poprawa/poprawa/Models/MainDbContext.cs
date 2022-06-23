using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<File>(p => {

                p.HasKey(u => new { u.FileId, u.TeamId });
            
            });

            modelBuilder.Entity<Membership>(p => {

                p.HasKey(u => new { u.MemberId, u.TeamId });

            });


        }
    }
}
