using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogAPI_2.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("secret-storage")]
        public IActionResult StorePassword([FromBody] string superSecretString)
        {
            // BAD EXAMPLE: Storing password in cleartext
            var filePath = Path.Combine("Passwords", $"{superSecretString}.txt");
            System.IO.File.WriteAllText(filePath, superSecretString);

            return Ok("Secret stored successfully.");
        }

        [HttpPost("log-message")]
        public IActionResult LogMessage([FromBody] LogMessage logMessage)
        {
            // SAFE EXAMPLE: Avoiding uncontrolled format string
            string logEntry = logMessage.Message;
            System.IO.File.AppendAllText("log.txt", logEntry + "\n");

            return Ok("Message logged successfully.");
        }
    }
    public class LogMessage
    {
        public string Message { get; set; }
    }
}
