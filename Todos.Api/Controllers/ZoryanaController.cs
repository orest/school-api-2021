using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoryanaController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new { message = "Zoryana is the best!!!!" });

        }
    }
}
