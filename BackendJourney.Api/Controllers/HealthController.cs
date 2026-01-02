using Microsoft.AspNetCore.Mvc;

namespace BackendJourney.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
           return Ok(new{
             status = "OK",
             time = DateTime.UtcNow
           });
        }
    }
}