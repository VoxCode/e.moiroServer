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
    public class OccupationFormMaxVariableTopicHoursController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OccupationFormMaxVariableTopicHoursController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OccupationFormMaxVariableTopicHour>>> Get()
        {
            return await _context.OccupationFormMaxVariableTopicHours.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(int trainingProgramId, int trainingProgramCurriculumSectionId)
        {
            var tmp = from first in _context.OccupationFormMaxVariableTopicHours
                      .Where(a => a.TrainingProgramCurriculumSectionId == trainingProgramId && a.TrainingProgramCurriculumSectionId == trainingProgramCurriculumSectionId)
                      join second in _context.OccupationForms on first.OccupationFormId equals second.Id
                      select new
                      {
                          first.Id,
                          first.MaxVariableTopicHours,
                          first.OccupationFormId,
                          first.TrainingProgramCurriculumSectionId,
                          second.FullName
                      };
            return await tmp.ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(OccupationFormMaxVariableTopicHour value)
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
        public async Task<ActionResult<OccupationFormMaxVariableTopicHour>> Post(OccupationFormMaxVariableTopicHour value)
        {
            if (ModelState.IsValid)
            {
                _context.OccupationFormMaxVariableTopicHours.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OccupationFormMaxVariableTopicHour>> Delete(int id)
        {
            var value = await _context.OccupationFormMaxVariableTopicHours.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.OccupationFormMaxVariableTopicHours.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
