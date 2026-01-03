
namespace BackendJourney.Api.Services 
{
  public class HealthService : IHealthService
  {
    public object GetHealthStatus() 
    {
       return new 
       {
        status = "OK",
        time = DateTime.UtcNow
       };
    }
  }
}

