
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eskitech.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdukterController : ControllerBase
    {

        private readonly IProduktService _produktService;

        public ProdukterController(IProduktService produktService)
        {
            _produktService = produktService;
        }


        [HttpGet("GetAll")]
        public ActionResult<List<Produkter>> Get()
        {
            return Ok(_produktService.GetAllProdukters());
        }
        [HttpGet("{produktID}")]
        public ActionResult<List<Produkter>> GetSingle(int produktID)
        {
            return Ok(_produktService.GetProduktersByID(produktID));
        }
    }
}