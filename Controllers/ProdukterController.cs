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
        private static Produkter TwintipSkidor = new Produkter();

        public IActionResult Get()
        {
            return Ok(TwintipSkidor);
        }
    }
}