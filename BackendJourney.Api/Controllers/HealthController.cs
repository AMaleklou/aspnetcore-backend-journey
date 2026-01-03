using Microsoft.AspNetCore.Mvc;
using BackendJourney.Api.Services;

namespace BackendJourney.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;
        public HealthController(IHealthService healthService) 
        { 
            _healthService = healthService;
        }

        [HttpGet]
        public IActionResult Get() 
        {
           var result = _healthService.GetHealthStatus();
           return Ok(result);
        } 
    }
}