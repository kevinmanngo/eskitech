using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models
{
    public class Produkter
    {
        public int ProduktID { get; set; } = 0;
        public string Namn { get; set; } = "Namn";
        public string Storlek { get; set; } = "Storlek";
        public int LagerSaldo { get; set; } = 0;
        public int Pris { get; set; } = 0;

        public EskiClass Kategori { get; set; } = EskiClass.ValjKategori;


    }
}