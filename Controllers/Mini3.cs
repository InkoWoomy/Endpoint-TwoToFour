using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_TwoToFour.Services.Mini3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini3 : Controller
    {
        private readonly IWakeUp _logger;

        public Mini3(IWakeUp logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini3/{name}/{time}")]
        public string Awoken(string name, int time)
        {
            return _logger.Awoken(name, time);
        }
    }
}