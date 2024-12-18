using Microsoft.AspNetCore.Mvc;

namespace Rkst03ASP1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Rkst03ASP1BaseController : ControllerBase {
    public string Author { get; set; } = "Eliel";
}