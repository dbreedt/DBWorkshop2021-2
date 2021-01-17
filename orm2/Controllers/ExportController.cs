using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using orm2.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace orm2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        // DEMO add these lines
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;

        // DEMO Update the constructor to look like this
        public ExportController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }

        // DEMO Change this method
        // GET: api/<ExportController>
        [HttpGet]
        public IEnumerable<Export> Get()
        {
            return _context.Exports;
        }

        // GET api/<ExportController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExportController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExportController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExportController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
