using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Swashbuckle.AspNetCore.Annotations;
using System.Text;
using System.Security.Cryptography;

//Test
namespace Flex.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        //public WeatherForecastController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public WeatherForecastController()
        {
        }

        [HttpGet("checkdatabase")]
        public async Task<IActionResult> CheckDatabaseConnection()
        {
            try
            {
                // Thực hiện một truy vấn đơn giản để kiểm tra kết nối
                await _context.Database.ExecuteSqlRawAsync("SELECT 1 FROM DUAL");
                return Ok("Database connection is successful.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpGet(Name = "GetWeatherForecast")]
        [SwaggerOperation(Summary = "Get weather forecast", Description = "Retrieve weather forecast data for the next 5 days")]
        [SwaggerResponse(200, "Returns the weather forecast", typeof(IEnumerable<WeatherForecast>))]
        public IEnumerable<WeatherForecast> Get()
        {
            Log.Information("Batch job executed at: " + DateTime.Now);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("ok")]
        public IActionResult DivideOrders([FromQuery] int Q, [FromQuery] int N, [FromQuery] int tradelot)
        {
            if (Q < tradelot * N)
            {
                return BadRequest("Total quantity Q must be at least N times the tradelot.");
            }

            var orders = DivideOrdersLogic(Q, N, tradelot);

            return Ok(orders);
        }

        private List<int> DivideOrdersLogic(int Q, int N, int tradelot)
        {
            var orders = new List<int>();
            int remainingQ = Q;

            for (int i = 0; i < N; i++)
            {
                int maxPossible = remainingQ - tradelot * (N - 1 - i);
                int orderQty = Math.Min(remainingQ, maxPossible / (N - i)) / tradelot * tradelot;
                orders.Add(orderQty);
                remainingQ -= orderQty;
            }

            return orders;
        }

        private string GenEncryptPassword(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return inputString;
            }

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        [HttpGet("demo")]
        public IActionResult Test()
        {
            var test = GenEncryptPassword("123456");

            return Ok(test);
        }
    }
}
