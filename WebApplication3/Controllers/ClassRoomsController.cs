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
    public class ClassRoomsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClassRoomsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassRoom>>> Get()
        {
            return await _context.ClassRooms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassRoom>> Get(int id)
        {
            var value = await _context.ClassRooms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(ClassRoom value)
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
        public async Task<ActionResult<ClassRoom>> Post(ClassRoom value)
        {
            if (ModelState.IsValid)
            {
                _context.ClassRooms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassRoom>> Delete(int id)
        {
            var value = await _context.ClassRooms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ClassRooms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
