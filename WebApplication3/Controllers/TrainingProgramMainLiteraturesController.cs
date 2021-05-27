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
        public async Task<ActionResult<TrainingProgramMainLiterature>> Get(int id)
        {
            var value = await _context.TrainingProgramMainLiteratures.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromTrainingProgram/{trainingProgramId}")]
        public async Task<ActionResult<IEnumerable<TrainingProgramMainLiterature>>> GetFromTrainingProgram(int trainingProgramId)
        {
            return await _context.TrainingProgramMainLiteratures.Where(a => a.TrainingProgramId == trainingProgramId).ToListAsync();
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

        [HttpPut("SerialNumbers")]
        public async Task<ActionResult<TrainingProgramMainLiterature>> PutSerialNumbers([FromBody] List<TrainingProgramMainLiterature> values)
        {
            if (ModelState.IsValid)
            {
                foreach (var value in values)
                {
                    _context.Update(value);
                }
                await _context.SaveChangesAsync();
                return Ok();
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
