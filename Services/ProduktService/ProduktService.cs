global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eskitech.Models.Services.ProduktService
{
    public class ProduktService : IProduktService
    {
        private static List<Produkter> produkters = new List<Produkter>{
            new Produkter {ProduktID = 1, Namn = "Stav X2000", Kategori = EskiClass.Stavar, LagerSaldo = 50, Pris = 200},
            new Produkter {ProduktID = 2, Namn = "Goggles", Kategori = EskiClass.Goggles, LagerSaldo = 12, Pris = 899},
            new Produkter {ProduktID = 3, Namn = "Twintip", Kategori = EskiClass.Skidor, LagerSaldo = 40, Pris = 999},
            new Produkter {ProduktID = 4, Namn = "Pjäxa", Kategori = EskiClass.Pjaxor, LagerSaldo = 2, Pris = 4500},
            new Produkter {ProduktID = 5, Namn = "Blades", Kategori = EskiClass.Skidor, LagerSaldo = 13, Pris = 79}
        };
        private readonly IMapper _mapper;

        public ProduktService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetProduktDto>>> GetAllProdukters()
        {
            var serviceResponse = new ServiceResponse<List<GetProduktDto>>();
            serviceResponse.Data = produkters.Select(p => _mapper.Map<GetProduktDto>(p)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetProduktDto>> GetProduktersByID(int produktID)
        {
            var serviceResponse = new ServiceResponse<GetProduktDto>();
            var produkter = produkters.FirstOrDefault(p => p.ProduktID == produktID);
            serviceResponse.Data = _mapper.Map<GetProduktDto>(produkter);
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetProduktDto>>> GetSortedProduktersByPrice()
        {
            var serviceResponse = new ServiceResponse<List<GetProduktDto>>();
            var sortedProdukts = produkters.OrderBy(p => p.Pris).Select(p => _mapper.Map<GetProduktDto>(p)).ToList();
            serviceResponse.Data = sortedProdukts;
            return serviceResponse;
        }
    }
}