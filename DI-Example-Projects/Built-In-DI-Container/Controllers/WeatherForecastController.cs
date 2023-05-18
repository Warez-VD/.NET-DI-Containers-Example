using Built_In_DI_Container.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Built_In_DI_Container.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};
		private readonly IDateService _dateService;
		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(
			ILogger<WeatherForecastController> logger,
			IDateService dateService)
		{
			_logger = logger;
			_dateService = dateService;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = _dateService.Now().AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}