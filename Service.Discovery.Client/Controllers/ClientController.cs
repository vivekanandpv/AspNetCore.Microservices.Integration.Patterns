using Consul;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Discovery.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ConsulClient _consulClient;

        public ClientController(ConsulClient consulClient)
        {
            _consulClient = consulClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Uri> serviceUrls = new List<Uri>();
            var services = await _consulClient.Agent.Services();
            foreach (var service in services.Response)
            {
                var serviceUri = new Uri($"{service.Value.Address}:{service.Value.Port}");
                serviceUrls.Add(serviceUri);
            }

            return Ok(serviceUrls);
        }
    }
}
