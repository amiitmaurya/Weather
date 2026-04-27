using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Weather.Server.Models;

namespace Weather.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string apiKey = "b6ff0ac5c4317b1ae05f78bcd47da9ae";

        public WeatherController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> Get(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            var httpResponse = await _httpClient.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
            {
                return BadRequest("Error fetching weather");
            }

            var json = await httpResponse.Content.ReadAsStringAsync();


            var data = JsonConvert.DeserializeObject<WeatherModel>(json);

            return Ok(data);
        }

        [HttpGet("forecast/{city}")]
        public async Task<IActionResult> GetForecast(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={apiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return BadRequest("Error fetching forecast");

            var json = await response.Content.ReadAsStringAsync();

            return Content(json, "application/json");
        }

    }
}
