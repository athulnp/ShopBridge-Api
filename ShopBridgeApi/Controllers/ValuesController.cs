using Microsoft.AspNetCore.Mvc;

namespace ShopBridgeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet][Route("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
