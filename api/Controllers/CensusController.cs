using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("/[controller]")]
    public class CensusController: Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {Name = "Twinkles"});
        }
    }
}