using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prize.Models;

namespace Prize.data
{
    public class ElPrizeContext : DbContext
    {
        public ElPrizeContext(DbContextOptions<ElPrizeContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role>  Roles { get; set; }
        public DbSet<Log> Logs { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<StatusTrans> StatusTrans { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
