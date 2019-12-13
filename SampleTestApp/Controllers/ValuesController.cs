using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleTestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values/5
        [HttpGet ("{value}")]
        public string Get([FromBody] double value)
        {
            double f;
            f = value * 9 / 5 + 32;
            return (value + "celsius in Farenheit is:" + f);

        }
    }
}
