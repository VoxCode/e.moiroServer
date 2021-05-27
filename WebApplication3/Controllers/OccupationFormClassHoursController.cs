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
    public class OccupationFormClassHoursController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OccupationFormClassHoursController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("{curriculumTopicTrainingProgramId}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(int curriculumTopicTrainingProgramId)
        {
            var models = from first in _context.OccupationFormClassHours
                         .Where(a => a.CurriculumTopicTrainingProgramId == curriculumTopicTrainingProgramId)
                         join second in _context.OccupationForms on first.OccupationFormId equals second.Id
                         select new
                         {
                             first.OccupationFormId,
                             first.CurriculumTopicTrainingProgramId,
                             first.SerialNumber,
                             first.ClassHours,
                             second.FullName
                         };
            return await models.ToListAsync().ConfigureAwait(false);
        }

        [HttpGet("FromTrainingProgramCurriculumSection/{trainingProgramCurriculumSectionId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetFromTrainingProgramCurriculumSection(int trainingProgramCurriculumSectionId)
        {
            var models = from first in _context.OccupationFormClassHours
                         .Where(a => a.CurriculumTopicTrainingProgram.TrainingProgramCurriculumSection.Id == trainingProgramCurriculumSectionId)
                         join second in _context.OccupationForms on first.OccupationFormId equals second.Id
                      select new
                      {
                          first.OccupationFormId,
                          first.CurriculumTopicTrainingProgramId,
                          first.SerialNumber,
                          first.ClassHours,
                          second.FullName,
                          second.PluralName
                      };
            return await models.ToListAsync().ConfigureAwait(false);
        }

        [HttpPut]
        public async Task<IActionResult> Put(OccupationFormClassHour value)
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
        public async Task<ActionResult<OccupationFormClassHour>> Post(OccupationFormClassHour value)
        {
            if (ModelState.IsValid)
            {
                _context.OccupationFormClassHours.Add(value);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult<OccupationFormClassHour>> Delete(OccupationFormClassHour value)
        {
            _context.Remove(value);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}