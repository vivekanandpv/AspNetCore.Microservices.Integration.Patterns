using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Task.FromResult(new { Id = Guid.NewGuid().ToString(), Date = DateTime.Now.Date.ToString("dd-MM-yyyy"), Player = "Amit", Amount = 2568.5 }));
        }
    }
}
