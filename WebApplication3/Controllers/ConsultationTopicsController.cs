using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ConsultationTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ConsultationTopics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultationTopics>>> GetConsultationTopics()
        {
            return await _context.ConsultationTopics.ToListAsync();
        }

        // GET: api/ConsultationTopics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultationTopics>> GetConsultationTopics(int id)
        {
            var consultationTopics = await _context.ConsultationTopics.FindAsync(id);

            if (consultationTopics == null)
            {
                return NotFound();
            }

            return consultationTopics;
        }

        // PUT: api/ConsultationTopics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultationTopics(int id, ConsultationTopics consultationTopics)
        {
            if (id != consultationTopics.Id)
            {
                return BadRequest();
            }

            _context.Entry(consultationTopics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultationTopicsExists(id))
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

        // POST: api/ConsultationTopics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ConsultationTopics>> PostConsultationTopics(ConsultationTopics consultationTopics)
        {
            _context.ConsultationTopics.Add(consultationTopics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultationTopics", new { id = consultationTopics.Id }, consultationTopics);
        }

        // DELETE: api/ConsultationTopics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsultationTopics>> DeleteConsultationTopics(int id)
        {
            var consultationTopics = await _context.ConsultationTopics.FindAsync(id);
            if (consultationTopics == null)
            {
                return NotFound();
            }

            _context.ConsultationTopics.Remove(consultationTopics);
            await _context.SaveChangesAsync();

            return consultationTopics;
        }

        private bool ConsultationTopicsExists(int id)
        {
            return _context.ConsultationTopics.Any(e => e.Id == id);
        }
    }
}
