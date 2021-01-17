using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace liveCodingAPIRest.Controllers
{
    [ApiController] //Nommé également attribut par microsoft.
    [Route("[controller]")] //route du controleur indique que la route est tout ce qui est écrit avant "controller" ici weatherForecast
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet] //Cet attribut inque que la méthode en dessous répond au GET 
        [Route("[controler]/add")] //pour définir la route 
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost] //Cet attribut indique que 
        public WeatherForecast Post(WeatherForecast forecast) //ce qui est envoyé quand on fait post un objet weatherforecast est créé et retourné
        { 
            return forecast;
        }
    }
}
