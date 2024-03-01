
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
        public async Task<ActionResult<ServiceResponse<List<GetProduktDto>>>> Get()
        {
            return Ok(await _produktService.GetAllProdukters());
        }
        [HttpGet("{produktID}")]
        public async Task<ActionResult<ServiceResponse<List<GetProduktDto>>>> GetSingle(int produktID)
        {
            return Ok(await _produktService.GetProduktersByID(produktID));
        }
    }
}