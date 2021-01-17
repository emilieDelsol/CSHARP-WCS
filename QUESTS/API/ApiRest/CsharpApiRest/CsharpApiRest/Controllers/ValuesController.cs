using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CsharpApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<String> Get()
        {
            List<string> strings = new List<string> { "Hello", "world", "!! " };
            return strings;
        }
    }
}
