using Microsoft.AspNetCore.Mvc;

namespace BincomHelloWorld.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            return Content("Hello World");
        }
    }
}
