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
    public class TrainingProgramRegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramRegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramRegulation>>> Get()
        {
            return await _context.TrainingProgramRegulations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<object>> Get(int id)
        {
            var tmp = from first in _context.TrainingProgramRegulations.Where(a => a.TrainingProgramId == id)
                      join second in _context.Regulations on first.RegulationId equals second.Id
                      select new
                      {
                          first.Id,
                          first.RegulationId,
                          first.TrainingProgramId,
                          first.SerialNumber,
                          second.Content
                      };

            return await tmp.ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramRegulation value)
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
        public async Task<ActionResult<TrainingProgramRegulation>> Post(TrainingProgramRegulation value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramRegulations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramRegulation>> Delete(int id)
        {
            var value = await _context.TrainingProgramRegulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramRegulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
