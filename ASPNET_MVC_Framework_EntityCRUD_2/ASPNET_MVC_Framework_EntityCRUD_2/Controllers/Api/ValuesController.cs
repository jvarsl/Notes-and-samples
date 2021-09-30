using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult GetValues()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] string[] value)
        {
            if (value is null) return BadRequest();

            return Created("","");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
