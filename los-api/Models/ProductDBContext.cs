using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Stock> Stock { get; set; }

        public ProductDBContext(DbContextOptions<ProductDBContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Stock>()
                .HasOne(p => p.Product)
                .WithMany(b => b.Stock)
                .HasForeignKey(p => p.ProductID);
        }
    }
}
