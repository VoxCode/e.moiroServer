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
    public class ScheduleBlockClassRoomsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlockClassRoomsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlockClassRoom>>> Get()
        {
            return await _context.ScheduleBlockClassRooms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlockClassRoom>> Get(int id)
        {
            var value = await _context.ScheduleBlockClassRooms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromScheduleBlock/{scheduleBlockId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetFromScheduleBlock(int scheduleBlockId)
        {

            var tmp = from mixedInBlock in _context.ScheduleBlockClassRooms.Where(mixedInBlock => mixedInBlock.ScheduleBlockId == scheduleBlockId)
                      join classRoom in _context.ClassRooms on mixedInBlock.ClassRoomId equals classRoom.Id
                      select new
                      {
                          mixedInBlock.Id,
                          mixedInBlock.ScheduleBlockId,
                          mixedInBlock.ClassRoomId,
                          classRoom.Name,
                          mixedInBlock.SerialNumber
                      };

            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlockClassRoom value)
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
        public async Task<ActionResult<ScheduleBlockClassRoom>> PutSerialNumbers([FromBody] List<ScheduleBlockClassRoom> values)
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
        public async Task<ActionResult<ScheduleBlockClassRoom>> Post(ScheduleBlockClassRoom value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlockClassRooms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlockClassRoom>> Delete(int id)
        {
            var value = await _context.ScheduleBlockClassRooms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlockClassRooms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
