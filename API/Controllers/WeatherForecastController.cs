using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICodesService _codesService;

        public WeatherForecastController(ICodesService codesService)
        {
            _codesService = codesService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Code Get()
        {
            return _codesService.Get("2", "NivelEducativo");
        }
    }
}