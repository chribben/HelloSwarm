using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/api/hello")]
    public class HelloController
    {

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("Hello brave new Docker version 2!");
        }
    }
}
