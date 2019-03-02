using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YeahModels.Data;
using YeahModels.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YeahApi.Controllers
{
    [Route("api/[controller]")]
	[Produces("application/json")]
    public class EmployeeController : Controller
    {
	    private readonly ApplicationDbContext _ctx;

	    public EmployeeController(ApplicationDbContext dbContext)
	    {
		    _ctx = dbContext;
	    }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> Get()
        {
	        return await _ctx.People.ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
	        throw new NotImplementedException();
		}

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
	        throw new NotImplementedException();
		}

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
	        throw new NotImplementedException();
		}
    }
}
