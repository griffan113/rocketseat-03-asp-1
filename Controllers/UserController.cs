using Microsoft.AspNetCore.Mvc;
using Rkst03ASP1.Communication.Requests;
using Rkst03ASP1.Communication.Responses;
using Rkst03ASP1.Entities;

namespace Rkst03ASP1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase {
    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll() {
        var response = new List<User>() {
            new User {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@gmail.com",
                Age = 20
            },
            new User {
                Id = 2,
                Name = "John Doe",
                Email = "john.doe@gmail.com",
                Age = 20
            }
        };

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id) {
        var response = new User {
            Age = 21,
            Name = "James da Salada de Fruta"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request) {
        var response = new ResponseRegisterUserJson {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateUserProfileJson request) {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id) {
        return NoContent();
    }
    
    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request) {
        return NoContent();
    }
}