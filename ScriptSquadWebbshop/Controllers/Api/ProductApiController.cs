using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScriptSquadWebbshop.Data;
using ScriptSquadWebbshop.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScriptSquadWebbshop.Controllers.Api
{
    [Route("api/ProductApi")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductApiController(ApplicationDbContext context)
        { 
            _context = context;
        }

        // GET: api/ProductApi
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.Procuct.ToListAsync();
            return Ok(data);
        }

        // GET api/ProductApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _context.Procuct.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //// POST api/ProductApi
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/ProductApi/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/ProductApi/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
