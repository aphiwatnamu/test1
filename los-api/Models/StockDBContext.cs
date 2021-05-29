using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class StockDBContext : DbContext
    {
        public DbSet<Stock> Stock { get; set; }

        public StockDBContext(DbContextOptions<StockDBContext> options) : base(options)
        {

        }
    }
}
