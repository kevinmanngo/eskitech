using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eskitech.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Produkter> Produkter => Set<Produkter>();
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        
    }
}