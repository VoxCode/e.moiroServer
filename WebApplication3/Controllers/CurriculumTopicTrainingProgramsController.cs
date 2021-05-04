using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumTopicTrainingProgramsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicTrainingProgramsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTrainingProgram>>> Get()
        {
            return await _context.CurriculumTopicTrainingPrograms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Get(int id)
        {
            var value = await _context.CurriculumTopicTrainingPrograms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("TrainingProgram/{trainingProgramCurriculumSectionId}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTrainingProgram>>> GetFromTrainingProgram(int trainingProgramCurriculumSectionId)
        {
            return await _context.CurriculumTopicTrainingPrograms
                .Where(a => a.TrainingProgramCurriculumSectionId == trainingProgramCurriculumSectionId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Post(CurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTrainingPrograms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTrainingPrograms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTrainingPrograms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
