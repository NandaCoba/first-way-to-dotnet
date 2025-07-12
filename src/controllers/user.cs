using Microsoft.AspNetCore.Mvc;

namespace User.Controller;

[ApiController]
[Route("/api/user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUser()
    {
        return Ok(new { name = "nanda", age = 19 });
    }

    [HttpGet("id")]
    public IActionResult GetOneUser(int id)
    {
        return Ok(new { id = id });
    }

    [HttpPost]
    public IActionResult CreateUser(UserRequest req)
    {
        return Ok(new { message = $"user {req.name} dengan usia {req.age} berhasil di tambahkan" });
    }
}