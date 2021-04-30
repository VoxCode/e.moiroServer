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
    public class TrainingProgramAdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramAdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramAdditionalLiterature>>> Get()
        {
            return await _context.TrainingProgramAdditionalLiteratures.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<object>> Get(int id)
        //{
        //    var tmp = from first in _context.TrainingProgramAdditionalLiteratures.Where(a => a.TrainingProgramId == id)
        //              join second in _context.AdditionalLiteratures on first.AdditionalLiteratureId equals second.Id
        //              select new
        //              {
        //                  first.Id,
        //                  first.AdditionalLiteratureId,
        //                  first.TrainingProgramId,
        //                  first.SerialNumber,
        //                  second.Content
        //              };

        //    return await tmp.ToListAsync();
        //}

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramAdditionalLiterature value)
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
        public async Task<ActionResult<TrainingProgramAdditionalLiterature>> Post(TrainingProgramAdditionalLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramAdditionalLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramAdditionalLiterature>> Delete(int id)
        {
            var value = await _context.TrainingProgramAdditionalLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramAdditionalLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
