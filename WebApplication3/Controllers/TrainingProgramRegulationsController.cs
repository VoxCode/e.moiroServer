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
    public class TrainingProgramRegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramRegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramRegulations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramRegulation>>> GetTrainingProgramRegulations()
        {
            return await _context.TrainingProgramRegulations.ToListAsync();
        }

        // GET: api/TrainingProgramRegulations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramRegulation>> GetTrainingProgramRegulation(int id)
        {
            var trainingProgramRegulation = await _context.TrainingProgramRegulations.FindAsync(id);

            if (trainingProgramRegulation == null)
            {
                return NotFound();
            }

            return trainingProgramRegulation;
        }

        // PUT: api/TrainingProgramRegulations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramRegulation(int id, TrainingProgramRegulation trainingProgramRegulation)
        {
            if (id != trainingProgramRegulation.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramRegulation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramRegulationExists(id))
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

        // POST: api/TrainingProgramRegulations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramRegulation>> PostTrainingProgramRegulation(TrainingProgramRegulation trainingProgramRegulation)
        {
            _context.TrainingProgramRegulations.Add(trainingProgramRegulation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramRegulation", new { id = trainingProgramRegulation.Id }, trainingProgramRegulation);
        }

        // DELETE: api/TrainingProgramRegulations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramRegulation>> DeleteTrainingProgramRegulation(int id)
        {
            var trainingProgramRegulation = await _context.TrainingProgramRegulations.FindAsync(id);
            if (trainingProgramRegulation == null)
            {
                return NotFound();
            }

            _context.TrainingProgramRegulations.Remove(trainingProgramRegulation);
            await _context.SaveChangesAsync();

            return trainingProgramRegulation;
        }

        private bool TrainingProgramRegulationExists(int id)
        {
            return _context.TrainingProgramRegulations.Any(e => e.Id == id);
        }
    }
}
