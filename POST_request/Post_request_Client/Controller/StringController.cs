using Microsoft.AspNetCore.Mvc;

namespace String.Controllers;

[ApiController]
[Route("api/string")]
public class StringController : ControllerBase
{
        private static readonly List<string> messages = new(); // Stores messages

    [HttpPost]
    public IActionResult PostString([FromBody] string message)
    {
        messages.Add(message);
        return Ok($"Message received: {message}");
    }

    [HttpGet]
    public IActionResult GetMessages()
    {
        return Ok(messages);
    }
}