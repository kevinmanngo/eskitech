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
            new Produkter(),
            new Produkter {ProduktID = 1, Namn = "Stav X2000", Kategori = EskiClass.Stavar, LagerSaldo = 50, Pris = 999, Storlek = "Barn 9-12"}
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
    }
}