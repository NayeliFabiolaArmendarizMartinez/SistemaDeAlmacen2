using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlmacen2.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=Base3; Username=postgres; password=1234567;")
                .EnableSensitiveDataLogging(true);

            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<ProductosAlmacen> ProductosAlmacen { get; set; }
    }
}
