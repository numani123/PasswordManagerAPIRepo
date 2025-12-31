using Microsoft.AspNetCore.Mvc;
using PasswordManagerAPI.Application.Dtos;
using PasswordManagerAPI.Application.Services;

namespace PasswordManagerAPI.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class WeatherForecastController : ControllerBase
   {
      private readonly ILogger<WeatherForecastController> logger;
      private readonly IWeatherForecastService weatherForecastService;

      public WeatherForecastController(ILogger<WeatherForecastController> logger,
         IWeatherForecastService weatherForecastService)
      {
         this.weatherForecastService = weatherForecastService;
         this.logger = logger;
      }

      [HttpGet(Name = "GetWeatherForecast")]
      public IEnumerable<WeatherForecastDto> Get()
      {
         return weatherForecastService.GetAllWeatherForecasts();
      }
   }
}
