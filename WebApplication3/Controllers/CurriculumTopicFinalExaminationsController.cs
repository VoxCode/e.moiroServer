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
    public class CurriculumTopicFinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicFinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicFinalExaminations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicFinalExamination>>> GetCurriculumTopicFinalExaminations()
        {
            return await _context.CurriculumTopicFinalExaminations.ToListAsync();
        }

        // GET: api/CurriculumTopicFinalExaminations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicFinalExamination>> GetCurriculumTopicFinalExamination(int id)
        {
            var curriculumTopicFinalExamination = await _context.CurriculumTopicFinalExaminations.FindAsync(id);

            if (curriculumTopicFinalExamination == null)
            {
                return NotFound();
            }

            return curriculumTopicFinalExamination;
        }

        // PUT: api/CurriculumTopicFinalExaminations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicFinalExamination(int id, CurriculumTopicFinalExamination curriculumTopicFinalExamination)
        {
            if (id != curriculumTopicFinalExamination.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicFinalExamination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicFinalExaminationExists(id))
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

        // POST: api/CurriculumTopicFinalExaminations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicFinalExamination>> PostCurriculumTopicFinalExamination(CurriculumTopicFinalExamination curriculumTopicFinalExamination)
        {
            _context.CurriculumTopicFinalExaminations.Add(curriculumTopicFinalExamination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicFinalExamination", new { id = curriculumTopicFinalExamination.Id }, curriculumTopicFinalExamination);
        }

        // DELETE: api/CurriculumTopicFinalExaminations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicFinalExamination>> DeleteCurriculumTopicFinalExamination(int id)
        {
            var curriculumTopicFinalExamination = await _context.CurriculumTopicFinalExaminations.FindAsync(id);
            if (curriculumTopicFinalExamination == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicFinalExaminations.Remove(curriculumTopicFinalExamination);
            await _context.SaveChangesAsync();

            return curriculumTopicFinalExamination;
        }

        private bool CurriculumTopicFinalExaminationExists(int id)
        {
            return _context.CurriculumTopicFinalExaminations.Any(e => e.Id == id);
        }
    }
}
