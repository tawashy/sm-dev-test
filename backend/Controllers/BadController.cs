using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BadController : ControllerBase
    {
        private readonly ILogger<BadController> _logger;
        private readonly IConfiguration _configuration;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public BadController(ILogger<BadController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetFromDb")]
        public WeatherForecast Get(string id)
        {
            // using (SqlConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionString")))
            // {
            //    connection.Open();
            //    SqlCommand command = new SqlCommand($"SELECT * FROM NonSensitiveDataTable WHERE Id = {id}", connection);
            //    using (var reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            string returnString = string.Empty;
            //            returnString += $"Name : {reader["Name"]}. ";
            //            returnString += $"Description : {reader["Description"]}";
            //            return new WeatherForecast() { Summary = returnString, TemperatureC = 15 };
            //        }
            //        else
            //        {
            //            return new WeatherForecast() { Summary = "Sunny", TemperatureC = 20 };
            //        }
            //    }
            // }

            return new WeatherForecast() { Summary = "Sunny", TemperatureC = 20 };
        }
    }
    
}
