using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudentsController.Controllers
{
    [ApiController]
    [Route("api/v1/students")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            var students = new List<string> { "a", "a" };
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete()
        {
            return Ok();
        }

    }
}
