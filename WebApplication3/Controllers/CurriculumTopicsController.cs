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
    public class CurriculumTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> Get()
        {
            return await _context.CurriculumTopics.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopic>> Get(int id)
        {
            var value = await _context.CurriculumTopics.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("TrainingProgram/{trainingProgramId}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> GetByTrainingProgram(int trainingProgramId)
        {
            return await _context.CurriculumTopics.Where(a => a.TrainingPrograms.Any(b => b.Id == trainingProgramId)).ToListAsync();
        }

        [HttpGet("{studentCategoryId}/{departmentId}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> Get(int studentCategoryId, int departmentId)
        {
            var result = await _context.CurriculumTopics.Where(a => a.TrainingPrograms
            .Any(r => r.StudentCategoryId == studentCategoryId && r.DepartmentId == departmentId)).ToListAsync();
            return result;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopic value)
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
        public async Task<ActionResult<CurriculumTopic>> Post(CurriculumTopic value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopics.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopic>> Delete(int id)
        {
            var value = await _context.CurriculumTopics.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopics.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
