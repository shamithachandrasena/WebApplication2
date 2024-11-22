using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("custom-api")]
    public class HomeController : Controller
    {
        [HttpGet("hi")]
        public String hi()
        {
            return "hi";
        }
    }
}
