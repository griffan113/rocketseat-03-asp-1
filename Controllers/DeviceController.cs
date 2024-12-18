using Microsoft.AspNetCore.Mvc;

namespace Rkst03ASP1.Controllers;

public class DeviceController : Rkst03ASP1BaseController {
    [HttpGet]
    public IActionResult Get() {
        return Ok(this.Author);
    }
}