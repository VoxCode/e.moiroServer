using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachingPositionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeachingPositionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TeachingPositions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeachingPosition>>> GetTeachingPositions()
        {
            return await _context.TeachingPositions.ToListAsync();
        }

        // GET: api/TeachingPositions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeachingPosition>> GetTeachingPosition(int id)
        {
            var teachingPosition = await _context.TeachingPositions.FindAsync(id);

            if (teachingPosition == null)
            {
                return NotFound();
            }

            return teachingPosition;
        }

        // PUT: api/TeachingPositions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeachingPosition(int id, TeachingPosition teachingPosition)
        {
            if (id != teachingPosition.Id)
            {
                return BadRequest();
            }

            _context.Entry(teachingPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeachingPositionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TeachingPositions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeachingPosition>> PostTeachingPosition(TeachingPosition teachingPosition)
        {
            _context.TeachingPositions.Add(teachingPosition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeachingPosition", new { id = teachingPosition.Id }, teachingPosition);
        }

        // DELETE: api/TeachingPositions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeachingPosition>> DeleteTeachingPosition(int id)
        {
            var teachingPosition = await _context.TeachingPositions.FindAsync(id);
            if (teachingPosition == null)
            {
                return NotFound();
            }

            _context.TeachingPositions.Remove(teachingPosition);
            await _context.SaveChangesAsync();

            return teachingPosition;
        }

        private bool TeachingPositionExists(int id)
        {
            return _context.TeachingPositions.Any(e => e.Id == id);
        }
    }
}
