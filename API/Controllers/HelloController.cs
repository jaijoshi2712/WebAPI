using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world");
        }

        [HttpPost]

        public IActionResult Post(JObject payload)
        {
            return Ok(payload);
        }



    }
}

