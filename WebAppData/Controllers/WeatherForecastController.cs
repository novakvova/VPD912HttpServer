using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(
                new
                {
                    Name = "Рівне",
                    Date = "30.05.2021",
                    Temperature = 12,
                    Image = "images/temp.jpg"
                });
        }
    }
}
