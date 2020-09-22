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
    public class TrainingProgramCurriculumSectionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramCurriculumSectionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramCurriculumSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramCurriculumSection>>> GetTrainingProgramCurriculumSections()
        {
            return await _context.TrainingProgramCurriculumSections.ToListAsync();
        }

        // GET: api/TrainingProgramCurriculumSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramCurriculumSection>> GetTrainingProgramCurriculumSection(int id)
        {
            var trainingProgramCurriculumSection = await _context.TrainingProgramCurriculumSections.FindAsync(id);

            if (trainingProgramCurriculumSection == null)
            {
                return NotFound();
            }

            return trainingProgramCurriculumSection;
        }

        // PUT: api/TrainingProgramCurriculumSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramCurriculumSection(int id, TrainingProgramCurriculumSection trainingProgramCurriculumSection)
        {
            if (id != trainingProgramCurriculumSection.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramCurriculumSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramCurriculumSectionExists(id))
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

        // POST: api/TrainingProgramCurriculumSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramCurriculumSection>> PostTrainingProgramCurriculumSection(TrainingProgramCurriculumSection trainingProgramCurriculumSection)
        {
            _context.TrainingProgramCurriculumSections.Add(trainingProgramCurriculumSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramCurriculumSection", new { id = trainingProgramCurriculumSection.Id }, trainingProgramCurriculumSection);
        }

        // DELETE: api/TrainingProgramCurriculumSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramCurriculumSection>> DeleteTrainingProgramCurriculumSection(int id)
        {
            var trainingProgramCurriculumSection = await _context.TrainingProgramCurriculumSections.FindAsync(id);
            if (trainingProgramCurriculumSection == null)
            {
                return NotFound();
            }

            _context.TrainingProgramCurriculumSections.Remove(trainingProgramCurriculumSection);
            await _context.SaveChangesAsync();

            return trainingProgramCurriculumSection;
        }

        private bool TrainingProgramCurriculumSectionExists(int id)
        {
            return _context.TrainingProgramCurriculumSections.Any(e => e.Id == id);
        }
    }
}
