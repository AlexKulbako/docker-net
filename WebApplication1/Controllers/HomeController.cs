using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = "visits";

        int result = 10;

        return Ok(result);
    }
}