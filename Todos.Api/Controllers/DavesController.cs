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
    public class DavesController : ControllerBase
    {
        public IActionResult Get(int id)
        {
            return Ok(new { message = "Dave is a nice guy!!!!!" });
        }
    }
}
