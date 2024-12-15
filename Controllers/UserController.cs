using Microsoft.AspNetCore.Mvc;

namespace Rkst03ASP1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Teste");
    }
}