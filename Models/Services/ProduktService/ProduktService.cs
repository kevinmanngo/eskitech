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
            new Produkter {produktID = 1, Namn = "Stav"}
        };
        public List<Produkter> GetAllProdukters()
        {
            return produkters;
        }

        public Produkter GetProduktersByID(int produktID)
        {
            var produkter = produkters.FirstOrDefault(p => p.produktID == produktID);
            if (produkter is not null)
            return produkter;

            throw new Exception("Ingen produkt hittades");
        }
    }
}