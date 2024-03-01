using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models.Services.ProduktService
{
    public class ProduktService : IProduktService
    {
        private static List<Produkter> produkters = new List<Produkter>{
            new Produkter(),
            new Produkter {ProduktID = 1, Namn = "Stav X2000", Kategori = EskiClass.Stavar, LagerSaldo = 50, Pris = 999, Storlek = "Barn 9-12"}
        };
        public async Task<ServiceResponse<List<Produkter>>> GetAllProdukters()
        {
            var serviceResponse = new ServiceResponse<List<Produkter>>();
            serviceResponse.Data = produkters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Produkter>> GetProduktersByID(int produktID)
        {
            var serviceResponse = new ServiceResponse<Produkter>();
            var produkter = produkters.FirstOrDefault(p => p.ProduktID == produktID);
            serviceResponse.Data = produkter;
            return serviceResponse;
        }
    }
}