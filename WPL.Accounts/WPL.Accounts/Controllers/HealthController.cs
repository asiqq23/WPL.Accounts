using Microsoft.AspNetCore.Mvc;

namespace WPL.Accounts.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}