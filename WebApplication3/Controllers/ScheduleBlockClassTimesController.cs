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
    public class ScheduleBlockClassTimesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlockClassTimesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlockClassTime>>> Get()
        {
            return await _context.ScheduleBlockClassTimes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlockClassTime>> Get(int id)
        {
            var value = await _context.ScheduleBlockClassTimes.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromScheduleBlock/{scheduleBlockId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetFromScheduleBlock(int scheduleBlockId)
        {

            var tmp = from mixedInBlock in _context.ScheduleBlockClassTimes.Where(mixedInBlock => mixedInBlock.ScheduleBlockId == scheduleBlockId)
                      join classTime in _context.ClassTimes on mixedInBlock.ClassTimeId equals classTime.Id
                      select new
                      {
                          mixedInBlock.Id,
                          mixedInBlock.ScheduleBlockId,
                          mixedInBlock.ClassTimeId,
                          classTime.ClassTimeStart,
                          classTime.ClassTimeEnd,
                          mixedInBlock.SerialNumber
                      };
            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlockClassTime value)
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
        public async Task<ActionResult<ScheduleBlockClassTime>> PutSerialNumbers([FromBody] List<ScheduleBlockClassTime> values)
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
        public async Task<ActionResult<ScheduleBlockClassTime>> Post(ScheduleBlockClassTime value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlockClassTimes.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlockClassTime>> Delete(int id)
        {
            var value = await _context.ScheduleBlockClassTimes.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlockClassTimes.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
