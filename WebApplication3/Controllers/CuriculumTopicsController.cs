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
    public class CuriculumTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CuriculumTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CuriculumTopics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> GetCuriculumTopics()
        {
            return await _context.CuriculumTopics.ToListAsync();
        }

        // GET: api/CuriculumTopics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopic>> GetCuriculumTopic(int id)
        {
            var curiculumTopic = await _context.CuriculumTopics.FindAsync(id);

            if (curiculumTopic == null)
            {
                return NotFound();
            }

            return curiculumTopic;
        }

        // PUT: api/CuriculumTopics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuriculumTopic(int id, CurriculumTopic curiculumTopic)
        {
            if (id != curiculumTopic.Id)
            {
                return BadRequest();
            }

            _context.Entry(curiculumTopic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuriculumTopicExists(id))
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

        // POST: api/CuriculumTopics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopic>> PostCuriculumTopic(CurriculumTopic curiculumTopic)
        {
            _context.CuriculumTopics.Add(curiculumTopic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuriculumTopic", new { id = curiculumTopic.Id }, curiculumTopic);
        }

        // DELETE: api/CuriculumTopics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopic>> DeleteCuriculumTopic(int id)
        {
            var curiculumTopic = await _context.CuriculumTopics.FindAsync(id);
            if (curiculumTopic == null)
            {
                return NotFound();
            }

            _context.CuriculumTopics.Remove(curiculumTopic);
            await _context.SaveChangesAsync();

            return curiculumTopic;
        }

        private bool CuriculumTopicExists(int id)
        {
            return _context.CuriculumTopics.Any(e => e.Id == id);
        }
    }
}
