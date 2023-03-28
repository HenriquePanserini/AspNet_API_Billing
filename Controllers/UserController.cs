using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AspNet_API_App.Models;

namespace AspNet_API_App.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase {

    [HttpGet]
    public ActionResult<List<User>> getAllUsers() {
        return Ok();
    }
}