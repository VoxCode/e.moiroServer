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
        public async Task<ActionResult<IEnumerable<OccupationFormClassHour>>> Get(int curriculumTopicTrainingProgramId)
        {

            return await _context.OccupationFormClassHours.Where(a => a.CurriculumTopicTrainingProgramId == curriculumTopicTrainingProgramId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Regulation value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost("{curriculumTopicTrainingProgramId}")]
        public async Task<ActionResult<OccupationFormClassHour>> Post(int curriculumTopicTrainingProgramId, OccupationFormClassHour value)
        {
            if (ModelState.IsValid)
            {
                _context.OccupationFormClassHours.Add(value);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Regulation>> Delete(int id)
        {
            var value = await _context.Regulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Regulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
