using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eskitech.Models.Services.ProduktService
{
    public interface IProduktService
    {
        Task<ServiceResponse<List<GetProduktDto>>> GetAllProdukters();
        Task<ServiceResponse<GetProduktDto>> GetProduktersByID (int produktID);
        
    }
}