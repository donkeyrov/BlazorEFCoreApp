using BlazorEFCoreApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEFCoreApp.Server.Infrastructure
{
    public class BlazorDBContext : DbContext
    {
        public BlazorDBContext(): base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=MMUMBA;Initial Catalog=BlazorEFCore;Integrated Security=true;MultipleActiveResultSets=true");
            }
        }

        public DbSet<User> Users { get; set; }

    }
}
