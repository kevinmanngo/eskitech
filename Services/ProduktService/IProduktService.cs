using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models.Services.ProduktService
{
    public interface IProduktService
    {
        Task<ServiceResponse<List<Produkter>>> GetAllProdukters();
        Task<ServiceResponse<Produkter>> GetProduktersByID (int produktID);
        
    }
}