using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ExpertsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expert>>> Get()
        {
            return await _context.Experts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Expert>> Get(int id)
        {
            var value = await _context.Experts.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(Expert value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<Expert>> Post(Expert value)
        {
            if (ModelState.IsValid)
            {
                _context.Experts.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Expert>> Delete(int id)
        {
            var value = await _context.Experts.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Experts.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }

    }
}
