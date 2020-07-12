using ExtendedAuth.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendedAuth.Api.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; }

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("SQLiteDatabase"));
        }
    }
}
