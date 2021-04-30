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
    public class TrainingProgramFinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramFinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramFinalExamination>>> Get()
        {
            return await _context.TrainingProgramFinalExaminations.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<IEnumerable<object>>> Get(int id)
        //{
        //    var tmp = from first in _context.TrainingProgramFinalExaminations.Where(a => a.TrainingProgramId == id)
        //              join second in _context.FinalExaminations on first.FinalExaminationId equals second.Id
        //              select new
        //              {
        //                  first.Id,
        //                  first.FinalExaminationId,
        //                  first.TrainingProgramId,
        //                  first.SerialNumber,
        //                  second.Content
        //              };

        //    return await tmp.ToListAsync();
        //}

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramFinalExamination value)
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
        public async Task<ActionResult<TrainingProgramFinalExamination>> Post(TrainingProgramFinalExamination value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramFinalExaminations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramFinalExamination>> Delete(int id)
        {
            var value = await _context.TrainingProgramFinalExaminations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramFinalExaminations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
