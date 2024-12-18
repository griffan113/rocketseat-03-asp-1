using Microsoft.AspNetCore.Mvc;
using Rkst03ASP1.Entities;

namespace Rkst03ASP1.Controllers;

public class DeviceController : Rkst03ASP1BaseController {
    [HttpGet]
    public IActionResult Get() {
        var key = GetCustomKey();

        return Ok(key);
    }
}