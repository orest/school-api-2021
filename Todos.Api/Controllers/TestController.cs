using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Todos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public IActionResult Get() {
            return Ok(new { message = "Orest is a nice guyQQQ" });
        }

        public IActionResult Get(int id) {
            return Ok(new { message = "Orest is a nice guy!!!!!" });
        }
    }
}
