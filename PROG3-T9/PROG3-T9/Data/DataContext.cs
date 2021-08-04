using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROG3_T9.Data
{
    public class DataContext : DbContext
    {
        static string database = "VACUNACION.db";
        public DbSet<Request> Requests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(connectionString: "Filename=" + database,
                sqliteOptionsAction: op => {
                    op.MigrationsAssembly(
                        Assembly.GetExecutingAssembly().FullName
                        );
                });

            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder ModelB)
        {
            ModelB.Entity<Request>().ToTable("Requests");
            ModelB.Entity<Request>(e =>
            {
                e.HasKey(e => e.ID);
            });
            base.OnModelCreating(ModelB);
        }
    }
}
