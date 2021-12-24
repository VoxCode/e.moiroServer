using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleBlockTeachersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlockTeachersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlockTeacher>>> Get()
        {
            return await _context.ScheduleBlockTeachers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlockTeacher>> Get(int id)
        {
            var value = await _context.ScheduleBlockTeachers.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromScheduleBlock/{scheduleBlockId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetFromScheduleBlock(int scheduleBlockId)
        {
            var tmp = from mixedInBlock in _context.ScheduleBlockTeachers.Where(mixedInBlock => mixedInBlock.ScheduleBlockId == scheduleBlockId)
                      join teacher in _context.Teachers on mixedInBlock.TeacherId equals  teacher.Id
                      select new
                      {
                          mixedInBlock.Id,
                          mixedInBlock.ScheduleBlockId,
                          mixedInBlock.TeacherId,
                          teacher.FirstName,
                          teacher.LastName,
                          teacher.PatronymicName,
                          teacher.Position,
                          mixedInBlock.SerialNumber
                      };
            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlockTeacher value)
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
        public async Task<ActionResult<ScheduleBlockTeacher>> PutSerialNumbers([FromBody] List<ScheduleBlockTeacher> values)
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
        public async Task<ActionResult<ScheduleBlockTeacher>> Post(ScheduleBlockTeacher value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlockTeachers.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlockTeacher>> Delete(int id)
        {
            var value = await _context.ScheduleBlockTeachers.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlockTeachers.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
