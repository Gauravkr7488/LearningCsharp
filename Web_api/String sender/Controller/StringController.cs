using Microsoft.AspNetCore.Mvc;

namespace String.Controllers;

[ApiController]
[Route("api/string")]
public class StringController : ControllerBase
{
    [HttpGet]
    public IActionResult RecieveString()
    {
        return Ok("This is a string");
    }
}