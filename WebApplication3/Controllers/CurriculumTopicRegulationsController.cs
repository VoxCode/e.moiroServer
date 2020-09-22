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
    public class CurriculumTopicRegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicRegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicRegulations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicRegulation>>> GetCurriculumTopicRegulations()
        {
            return await _context.CurriculumTopicRegulations.ToListAsync();
        }

        // GET: api/CurriculumTopicRegulations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicRegulation>> GetCurriculumTopicRegulation(int id)
        {
            var curriculumTopicRegulation = await _context.CurriculumTopicRegulations.FindAsync(id);

            if (curriculumTopicRegulation == null)
            {
                return NotFound();
            }

            return curriculumTopicRegulation;
        }

        // PUT: api/CurriculumTopicRegulations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicRegulation(int id, CurriculumTopicRegulation curriculumTopicRegulation)
        {
            if (id != curriculumTopicRegulation.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicRegulation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicRegulationExists(id))
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

        // POST: api/CurriculumTopicRegulations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicRegulation>> PostCurriculumTopicRegulation(CurriculumTopicRegulation curriculumTopicRegulation)
        {
            _context.CurriculumTopicRegulations.Add(curriculumTopicRegulation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicRegulation", new { id = curriculumTopicRegulation.Id }, curriculumTopicRegulation);
        }

        // DELETE: api/CurriculumTopicRegulations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicRegulation>> DeleteCurriculumTopicRegulation(int id)
        {
            var curriculumTopicRegulation = await _context.CurriculumTopicRegulations.FindAsync(id);
            if (curriculumTopicRegulation == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicRegulations.Remove(curriculumTopicRegulation);
            await _context.SaveChangesAsync();

            return curriculumTopicRegulation;
        }

        private bool CurriculumTopicRegulationExists(int id)
        {
            return _context.CurriculumTopicRegulations.Any(e => e.Id == id);
        }
    }
}
