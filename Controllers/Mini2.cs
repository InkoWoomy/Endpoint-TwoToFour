using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_TwoToFour.Services.Mini2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini2 : Controller
    {
        private readonly IAddingNumbers _logger;

        public Mini2(IAddingNumbers logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini2/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _logger.AddTwoNumbers(num1, num2);
        }
    }
}