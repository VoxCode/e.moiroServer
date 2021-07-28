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
    public class ClassTimeController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClassTimeController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassTime>>> Get()
        {
            return await _context.ClassTimes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassTime>> Get(int id)
        {
            var value = await _context.ClassTimes.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(ClassTime value)
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
        public async Task<ActionResult<ClassTime>> Post(ClassTime value)
        {
            if (ModelState.IsValid)
            {
                _context.ClassTimes.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassTime>> Delete(int id)
        {
            var value = await _context.ClassTimes.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ClassTimes.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
