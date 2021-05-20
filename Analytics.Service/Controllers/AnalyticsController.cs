using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analytics.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Task.FromResult(new { Id = Guid.NewGuid().ToString(), Date = DateTime.Now, Score = 7.6, Depth = 46, SPI = 1.45, Average = 8.36 }));
        }
    }
}
