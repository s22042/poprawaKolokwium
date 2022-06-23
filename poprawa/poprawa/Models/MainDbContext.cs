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




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);





        }
    }
}
