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
    public class TrainingProgramMainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramMainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramMainLiterature>>> Get()
        {
            return await _context.TrainingProgramMainLiteratures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<object>> Get(int id)
        {
            var tmp = from first in _context.TrainingProgramMainLiteratures.Where(a => a.TrainingProgramId == id)
                      join second in _context.MainLiteratures on first.MainLiteratureId equals second.Id
                      select new
                      {
                          first.Id,
                          first.MainLiteratureId,
                          first.TrainingProgramId,
                          first.SerialNumber,
                          second.Content
                      };

            return await tmp.ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramMainLiterature value)
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
        public async Task<ActionResult<TrainingProgramMainLiterature>> Post(TrainingProgramMainLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramMainLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramMainLiterature>> Delete(int id)
        {
            var value = await _context.TrainingProgramMainLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramMainLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
