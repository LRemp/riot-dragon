using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IMetadataItemService _ItemsService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMetadataItemService itemsMetadataService)
        {
            _logger = logger;
            _ItemsService = itemsMetadataService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Item Get(int Id)
        {
            Item item = _ItemsService.FetchItem(Id);
            return item;
        }
    }
}