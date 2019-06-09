using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocoaTaskManager;
using Microsoft.AspNetCore.Mvc;

namespace CocboticsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoTaskController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            CocoaTask task = new CocoaTask() {OwnerName = "Luke", Index = id};
            return $"value is {id}";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string firstName)
        {
            //put your code here
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
