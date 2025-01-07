using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_TwoToFour.Services.Mini4;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini4 : Controller
    {
        private readonly ICompare _logger;

        public Mini4(ICompare logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini4/{num1}/{num2}")]
        public string GreaterThanLessThan(int num1, int num2)
        {
            return _logger.GreaterThanLessThan(num1, num2);
        }
    }
}