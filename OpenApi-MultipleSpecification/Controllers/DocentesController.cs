using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenApi_MultipleSpecification.Controllers
{
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "ColegioAPIEspDocentes")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        // GET: api/<DocentesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DocentesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocentesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocentesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocentesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
