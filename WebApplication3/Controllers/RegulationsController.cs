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
    public class RegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public RegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Regulations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Regulation>>> GetRegulations()
        {
            return await _context.Regulations.ToListAsync();
        }

        // GET: api/Regulations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Regulation>> GetRegulation(int id)
        {
            var regulation = await _context.Regulations.FindAsync(id);

            if (regulation == null)
            {
                return NotFound();
            }

            return regulation;
        }

        // PUT: api/Regulations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegulation(int id, Regulation regulation)
        {
            if (id != regulation.Id)
            {
                return BadRequest();
            }

            _context.Entry(regulation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegulationExists(id))
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

        // POST: api/Regulations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Regulation>> PostRegulation(Regulation regulation)
        {
            _context.Regulations.Add(regulation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegulation", new { id = regulation.Id }, regulation);
        }

        // DELETE: api/Regulations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Regulation>> DeleteRegulation(int id)
        {
            var regulation = await _context.Regulations.FindAsync(id);
            if (regulation == null)
            {
                return NotFound();
            }

            _context.Regulations.Remove(regulation);
            await _context.SaveChangesAsync();

            return regulation;
        }

        private bool RegulationExists(int id)
        {
            return _context.Regulations.Any(e => e.Id == id);
        }
    }
}
