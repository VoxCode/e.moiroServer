using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

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
        public async Task<ActionResult<IEnumerable<object>>> Get(int id)
        {
            var tmp = from first in _context.CurriculumTopicTrainingPrograms.Where(a => a.TrainingProgramId == id)
                      join second in _context.CurriculumTopics on first.CurriculumTopicId equals second.Id
                      select new
                      {
                          first.Id,
                          first.ClassHours,
                          first.CurriculumSectionId,
                          first.CurriculumTopicId,
                          first.IsVariable,
                          first.OccupationFormId,
                          first.SerialNumber,
                          first.TrainingProgramId,
                          second.TopicTitle
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("{trainingProgramId}/{curriculumSectionId}/{sectionNumber}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(int trainingProgramId, int curriculumSectionId, int sectionNumber)
        {
            var tmp = from first in _context.CurriculumTopicTrainingPrograms.Where(a => a.TrainingProgramId == trainingProgramId
                      && a.CurriculumSectionId == curriculumSectionId)
                      join second in _context.CurriculumTopics on first.CurriculumTopicId equals second.Id
                      join third in _context.OccupationForms on first.OccupationFormId equals third.Id
                      select new
                      {
                          first.Id,
                          first.ClassHours,
                          first.CurriculumSectionId,
                          first.CurriculumTopicId,
                          first.IsVariable,
                          first.OccupationFormId,
                          first.SerialNumber,
                          first.TrainingProgramId,
                          second.TopicTitle,
                          second.Annotation,
                          third.FullName,
                          third.ShortName
                      };

            return await tmp.ToListAsync().ConfigureAwait(false);
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
