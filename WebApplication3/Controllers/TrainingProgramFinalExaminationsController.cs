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
    public class TrainingProgramFinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramFinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramFinalExaminations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramFinalExamination>>> GetTrainingProgramFinalExaminations()
        {
            return await _context.TrainingProgramFinalExaminations.ToListAsync();
        }

        // GET: api/TrainingProgramFinalExaminations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramFinalExamination>> GetTrainingProgramFinalExamination(int id)
        {
            var trainingProgramFinalExamination = await _context.TrainingProgramFinalExaminations.FindAsync(id);

            if (trainingProgramFinalExamination == null)
            {
                return NotFound();
            }

            return trainingProgramFinalExamination;
        }

        // PUT: api/TrainingProgramFinalExaminations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramFinalExamination(int id, TrainingProgramFinalExamination trainingProgramFinalExamination)
        {
            if (id != trainingProgramFinalExamination.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramFinalExamination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramFinalExaminationExists(id))
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

        // POST: api/TrainingProgramFinalExaminations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramFinalExamination>> PostTrainingProgramFinalExamination(TrainingProgramFinalExamination trainingProgramFinalExamination)
        {
            _context.TrainingProgramFinalExaminations.Add(trainingProgramFinalExamination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramFinalExamination", new { id = trainingProgramFinalExamination.Id }, trainingProgramFinalExamination);
        }

        // DELETE: api/TrainingProgramFinalExaminations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramFinalExamination>> DeleteTrainingProgramFinalExamination(int id)
        {
            var trainingProgramFinalExamination = await _context.TrainingProgramFinalExaminations.FindAsync(id);
            if (trainingProgramFinalExamination == null)
            {
                return NotFound();
            }

            _context.TrainingProgramFinalExaminations.Remove(trainingProgramFinalExamination);
            await _context.SaveChangesAsync();

            return trainingProgramFinalExamination;
        }

        private bool TrainingProgramFinalExaminationExists(int id)
        {
            return _context.TrainingProgramFinalExaminations.Any(e => e.Id == id);
        }
    }
}
