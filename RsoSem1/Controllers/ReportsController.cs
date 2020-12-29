using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace RsoSem1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly Settings _settings;
        public ReportsController(IOptionsSnapshot<Settings> settings)
        {
            _settings = settings.Value;
        }
        // GET api/reports
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Test", _settings.Message };
        }

        // GET api/reports/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return File(System.IO.File.OpenRead("mejnik.json"), "application/json");
        }

        // POST api/reports
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/reports/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/reports/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}