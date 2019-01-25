using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Infrastructure.Base;
using Solution.Infrastructure.DBContext.PmiContext;
using Solution.Infrastructure.Entitys;

namespace Solution.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IList<TextEntity>> GetAsync()
        {
            DbBase db = new DbBase();
            var t = db.AddAsync<TextEntity>(
                new TextEntity {
                    Name = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            }).Result;
            var re = db.SqlQuery<TextEntity>("select * from Text order by id desc");
            return re;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
