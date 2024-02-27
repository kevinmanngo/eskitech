using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models
{
    public class Produkter
    {
        public int produktID { get; set; } = 0;
        public string Namn { get; set; } = "Namn";
        public string kategori { get; set; } = "Kategori";
        public string storlek { get; set; } = "Storlek";
        public int lagerSaldo { get; set; }
        public int pris { get; set; }

        public EskiClass Class { get; set; } = EskiClass.TwintipSkidor;


    }
}