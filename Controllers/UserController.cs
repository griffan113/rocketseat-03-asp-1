using Microsoft.AspNetCore.Mvc;

namespace Rkst03ASP1.Controllers;

internal class Response {
    public string Name { get; set; }
    public int Age { get; set; }
}

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase {
    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    public IActionResult Get(string name) {
        var response = new Response {
            Age = 21,
            Name = "James da Salada de Fruta"
        };

        return Ok(response);
    }
}