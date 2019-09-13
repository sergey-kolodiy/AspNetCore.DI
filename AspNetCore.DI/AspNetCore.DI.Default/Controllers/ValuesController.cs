using System.Collections.Generic;
using AspNetCore.DI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.DI.Default.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly S01 _s01;

        public ValuesController(S01 s01)
        {
            _s01 = s01;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1" };
        }
    }
}
