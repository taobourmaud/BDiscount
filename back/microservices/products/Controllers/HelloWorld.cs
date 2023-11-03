using Microsoft.AspNetCore.Mvc;

namespace products;

[ApiController]
[Route("api/hello")]
public class HelloWorldController : ControllerBase
{
    private readonly IHelloWorld _helloWorld;

    public HelloWorldController(IHelloWorld helloWorld)
    {
        _helloWorld = helloWorld;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var message = _helloWorld.GetHelloMessage();
        return Ok(message);
    }
}
