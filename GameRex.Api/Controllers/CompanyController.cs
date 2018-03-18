using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRex.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        // GET api/platofrm/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/platform
        [HttpPost]
        public void Post()
        {
        }
    }
}
