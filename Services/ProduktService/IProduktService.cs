using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models.Services.ProduktService
{
    public interface IProduktService
    {
        List<Produkter> GetAllProdukters();
        Produkter GetProduktersByID (int produktID);
        
    }
}