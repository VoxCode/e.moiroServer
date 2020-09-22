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
    public class TrainingProgramAdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramAdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramAdditionalLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramAdditionalLiterature>>> GetTrainingProgramAdditionalLiteratures()
        {
            return await _context.TrainingProgramAdditionalLiteratures.ToListAsync();
        }

        // GET: api/TrainingProgramAdditionalLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramAdditionalLiterature>> GetTrainingProgramAdditionalLiterature(int id)
        {
            var trainingProgramAdditionalLiterature = await _context.TrainingProgramAdditionalLiteratures.FindAsync(id);

            if (trainingProgramAdditionalLiterature == null)
            {
                return NotFound();
            }

            return trainingProgramAdditionalLiterature;
        }

        // PUT: api/TrainingProgramAdditionalLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramAdditionalLiterature(int id, TrainingProgramAdditionalLiterature trainingProgramAdditionalLiterature)
        {
            if (id != trainingProgramAdditionalLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramAdditionalLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramAdditionalLiteratureExists(id))
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

        // POST: api/TrainingProgramAdditionalLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramAdditionalLiterature>> PostTrainingProgramAdditionalLiterature(TrainingProgramAdditionalLiterature trainingProgramAdditionalLiterature)
        {
            _context.TrainingProgramAdditionalLiteratures.Add(trainingProgramAdditionalLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramAdditionalLiterature", new { id = trainingProgramAdditionalLiterature.Id }, trainingProgramAdditionalLiterature);
        }

        // DELETE: api/TrainingProgramAdditionalLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramAdditionalLiterature>> DeleteTrainingProgramAdditionalLiterature(int id)
        {
            var trainingProgramAdditionalLiterature = await _context.TrainingProgramAdditionalLiteratures.FindAsync(id);
            if (trainingProgramAdditionalLiterature == null)
            {
                return NotFound();
            }

            _context.TrainingProgramAdditionalLiteratures.Remove(trainingProgramAdditionalLiterature);
            await _context.SaveChangesAsync();

            return trainingProgramAdditionalLiterature;
        }

        private bool TrainingProgramAdditionalLiteratureExists(int id)
        {
            return _context.TrainingProgramAdditionalLiteratures.Any(e => e.Id == id);
        }
    }
}
