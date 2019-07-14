using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KrunalController : ControllerBase
    {


        // GET api/values
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Krunal1", "Krunal27" };
        }

        // GET api/values/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Krunal7";
        }
    }
}