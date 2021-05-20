using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Task.FromResult(new { Id = Guid.NewGuid().ToString(), Start = DateTime.Now.AddHours(-4), End = DateTime.Now, Player = "Amit", Facility = "WS30" }));
        }
    }
}
