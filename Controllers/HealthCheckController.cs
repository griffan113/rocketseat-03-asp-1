using Microsoft.AspNetCore.Mvc;

namespace Rkst03ASP1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HealthCheckController : ControllerBase {
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult Index() {
        return Ok("OK");
    }
}