using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI.Data
{
    public class TunesContext : DbContext
    {
        public TunesContext(DbContextOptions<TunesContext> options)
            : base(options)
        {
        }

        public DbSet<TunesAPI.Tunes> StockListing { get; set; }
    }
}
