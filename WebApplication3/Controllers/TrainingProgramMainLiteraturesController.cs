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
    public class TrainingProgramMainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramMainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramMainLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramMainLiterature>>> GetTrainingProgramMainLiteratures()
        {
            return await _context.TrainingProgramMainLiteratures.ToListAsync();
        }

        // GET: api/TrainingProgramMainLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramMainLiterature>> GetTrainingProgramMainLiterature(int id)
        {
            var trainingProgramMainLiterature = await _context.TrainingProgramMainLiteratures.FindAsync(id);

            if (trainingProgramMainLiterature == null)
            {
                return NotFound();
            }

            return trainingProgramMainLiterature;
        }

        // PUT: api/TrainingProgramMainLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramMainLiterature(int id, TrainingProgramMainLiterature trainingProgramMainLiterature)
        {
            if (id != trainingProgramMainLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramMainLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramMainLiteratureExists(id))
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

        // POST: api/TrainingProgramMainLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramMainLiterature>> PostTrainingProgramMainLiterature(TrainingProgramMainLiterature trainingProgramMainLiterature)
        {
            _context.TrainingProgramMainLiteratures.Add(trainingProgramMainLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramMainLiterature", new { id = trainingProgramMainLiterature.Id }, trainingProgramMainLiterature);
        }

        // DELETE: api/TrainingProgramMainLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramMainLiterature>> DeleteTrainingProgramMainLiterature(int id)
        {
            var trainingProgramMainLiterature = await _context.TrainingProgramMainLiteratures.FindAsync(id);
            if (trainingProgramMainLiterature == null)
            {
                return NotFound();
            }

            _context.TrainingProgramMainLiteratures.Remove(trainingProgramMainLiterature);
            await _context.SaveChangesAsync();

            return trainingProgramMainLiterature;
        }

        private bool TrainingProgramMainLiteratureExists(int id)
        {
            return _context.TrainingProgramMainLiteratures.Any(e => e.Id == id);
        }
    }
}
