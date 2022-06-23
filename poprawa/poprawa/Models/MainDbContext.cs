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

            modelBuilder.Entity<Organization>(p => {

                p.HasData(new Organization { OrganizationID =1, OrganizationName="google", OrganizationDomain="g"});
                p.HasData(new Organization { OrganizationID =2, OrganizationName="Microsoft", OrganizationDomain="microsoft"});
            
            });
            modelBuilder.Entity<Team>(p => {
                p.HasData(new Team {TeamId=1, OrganizationId=1,TeamName="Druzyna", TeamDescription="Pierscienia" });
                p.HasData(new Team {TeamId=2, OrganizationId=2,TeamName="Team", TeamDescription="kot" });
            
            
            });
            modelBuilder.Entity<Member>(p => {
                p.HasData(new Member { MemberId = 1, OrganizationId = 1, MemberName = "Ala", MemberSurname = "Kot", MemberNickName= "grzyb "});
                p.HasData(new Member { MemberId = 2, OrganizationId = 2, MemberName = "Pawel", MemberSurname = "Klekot", MemberNickName= "Szybki "});
            
            
            
            });

            modelBuilder.Entity<File>(p => {

                p.HasKey(u => new { u.FileId, u.TeamId });
                p.HasData(new File { FileId = 1, TeamId = 1, FileName = "plik", FileExtension = ".txt", FileSize = 1 });
                p.HasData(new File { FileId = 2, TeamId = 2, FileName = "plik2", FileExtension = ".txt", FileSize = 2 });
            
            });

            modelBuilder.Entity<Membership>(p => {

                p.HasKey(u => new { u.MemberId, u.TeamId });
                p.HasData(new Membership { MemberId = 1, TeamId = 1, MembershipDate = DateTime.Now });
                p.HasData(new Membership { MemberId = 2, TeamId = 2, MembershipDate = DateTime.Now });

            });


        }
    }
}
