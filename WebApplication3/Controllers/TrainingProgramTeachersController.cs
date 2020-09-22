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
    public class TrainingProgramTeachersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramTeachersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingProgramTeachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramTeacher>>> GetTrainingProgramTeachers()
        {
            return await _context.TrainingProgramTeachers.ToListAsync();
        }

        // GET: api/TrainingProgramTeachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramTeacher>> GetTrainingProgramTeacher(int id)
        {
            var trainingProgramTeacher = await _context.TrainingProgramTeachers.FindAsync(id);

            if (trainingProgramTeacher == null)
            {
                return NotFound();
            }

            return trainingProgramTeacher;
        }

        // PUT: api/TrainingProgramTeachers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingProgramTeacher(int id, TrainingProgramTeacher trainingProgramTeacher)
        {
            if (id != trainingProgramTeacher.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingProgramTeacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingProgramTeacherExists(id))
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

        // POST: api/TrainingProgramTeachers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrainingProgramTeacher>> PostTrainingProgramTeacher(TrainingProgramTeacher trainingProgramTeacher)
        {
            _context.TrainingProgramTeachers.Add(trainingProgramTeacher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingProgramTeacher", new { id = trainingProgramTeacher.Id }, trainingProgramTeacher);
        }

        // DELETE: api/TrainingProgramTeachers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramTeacher>> DeleteTrainingProgramTeacher(int id)
        {
            var trainingProgramTeacher = await _context.TrainingProgramTeachers.FindAsync(id);
            if (trainingProgramTeacher == null)
            {
                return NotFound();
            }

            _context.TrainingProgramTeachers.Remove(trainingProgramTeacher);
            await _context.SaveChangesAsync();

            return trainingProgramTeacher;
        }

        private bool TrainingProgramTeacherExists(int id)
        {
            return _context.TrainingProgramTeachers.Any(e => e.Id == id);
        }
    }
}
