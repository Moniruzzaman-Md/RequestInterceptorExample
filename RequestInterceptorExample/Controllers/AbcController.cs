using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RequestInterceptorExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbcController : ControllerBase
    {
        [HttpGet("Hello")]
        public IActionResult Get()
        {
            return BadRequest();
        }
    }
}
