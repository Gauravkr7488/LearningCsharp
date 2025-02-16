using Microsoft.AspNetCore.Mvc;

namespace String.Controllers;

[ApiController]
[Route("api/string")]
public class StringController : ControllerBase
{
    [HttpPost]
    public IActionResult PostString([FromBody] string message = "hello")
    {
        return Ok($"Message received: {message}");
    }
}