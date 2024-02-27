global using eskitech.Models;
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
        private static List<Produkter> produkters = new List<Produkter>{
            new Produkter(),
            new Produkter {produktID = 1, Namn = "Stav"}
        };
        [HttpGet("GetAll")]
        public ActionResult<List<Produkter>> Get()
        {
            return Ok(produkters);
        }
        [HttpGet("{produktID}")]
        public ActionResult<List<Produkter>> GetSingle(int produktID)
        {
            return Ok(produkters.FirstOrDefault(p => p.produktID == produktID));
        }
    }
}