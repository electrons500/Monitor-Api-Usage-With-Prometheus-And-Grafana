using Microsoft.AspNetCore.Mvc;

namespace ConsumerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ConsumersController : ControllerBase
{
    [HttpGet("GetConsumerName")]
    public ActionResult GetConsumerName()
    {
        string firstname = "Ishmael";
        string lastname = "Obeng";
        string consumerName = $"{firstname} {lastname}";
        if (string.IsNullOrEmpty(consumerName))
        {
            return NotFound();
        }

        return Ok(consumerName);

    }
}

