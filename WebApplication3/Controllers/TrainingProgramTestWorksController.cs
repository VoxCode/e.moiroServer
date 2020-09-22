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
    public class TrainingProgramTestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramTestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramTestWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramTestWork>>> GetTrainingProgramTestWorks()
        {
            return await _context.TrainingProgramTestWorks.ToListAsync();
        }

        // GET: api/TrainingProgramTestWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramTestWork>> GetTrainingProgramTestWork(int id)
        {
            var trainingProgramTestWork = await _context.TrainingProgramTestWorks.FindAsync(id);

            if (trainingProgramTestWork == null)
            {
                return NotFound();
            }

            return trainingProgramTestWork;
        }

        // PUT: api/TrainingProgramTestWorks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramTestWork(int id, TrainingProgramTestWork trainingProgramTestWork)
        {
            if (id != trainingProgramTestWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramTestWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramTestWorkExists(id))
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

        // POST: api/TrainingProgramTestWorks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramTestWork>> PostTrainingProgramTestWork(TrainingProgramTestWork trainingProgramTestWork)
        {
            _context.TrainingProgramTestWorks.Add(trainingProgramTestWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramTestWork", new { id = trainingProgramTestWork.Id }, trainingProgramTestWork);
        }

        // DELETE: api/TrainingProgramTestWorks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramTestWork>> DeleteTrainingProgramTestWork(int id)
        {
            var trainingProgramTestWork = await _context.TrainingProgramTestWorks.FindAsync(id);
            if (trainingProgramTestWork == null)
            {
                return NotFound();
            }

            _context.TrainingProgramTestWorks.Remove(trainingProgramTestWork);
            await _context.SaveChangesAsync();

            return trainingProgramTestWork;
        }

        private bool TrainingProgramTestWorkExists(int id)
        {
            return _context.TrainingProgramTestWorks.Any(e => e.Id == id);
        }
    }
}
