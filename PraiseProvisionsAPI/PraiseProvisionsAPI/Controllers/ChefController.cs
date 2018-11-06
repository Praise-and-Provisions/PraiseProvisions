using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PraiseProvisionsAPI.Data;
using PraiseProvisionsAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PraiseProvisionsAPI.Controllers
{
    [Route("api/[controller]")]
    public class ChefController : ControllerBase
    {
        public PraiseDBContext _context { get; set; }
        public ChefController(PraiseDBContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Chef>>Get()
        {
            return _context.Chefs;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<IActionResult> Get(int id)
        {
            var chef = _context.Chefs.FirstOrDefault(x => x.ID == id);
            if (chef == null)
            {
                return NotFound();
            }
            return Ok(chef);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
