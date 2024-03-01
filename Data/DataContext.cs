using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eskitech.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        public DbSet<Produkter> Produkter => Set<Produkter>();
    }
}