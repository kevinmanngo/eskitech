using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Produkter,GetProduktDto>();
        }
    }
}