using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MuseumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MuseumForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MuseumForecastController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public MuseumForecastController(ILogger<MuseumForecastController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<MuseumVisitorForecast> Get()
        {
            var client = _clientFactory.CreateClient("ignoressl");
            client.BaseAddress = new Uri("https://www.localhost:5001");
            var weatherResponse = await client.GetAsync("/weatherforecast/");
            var jsonString = await weatherResponse.Content.ReadAsStringAsync();
            var weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString); 
            
            // We could do some logic to check weather today and "fake" some logic to calc. a good museum day.
            // For now just keep it simple and return true.
            
            return new MuseumVisitorForecast
            {
                Date = DateTime.Now,
                WillGetManyVisitors = true
            };
        }
    }
}