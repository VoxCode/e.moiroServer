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
        public async Task<ActionResult<IEnumerable<ScheduleBlockTeacher>>> GetFromScheduleBlock(int scheduleBlockId)
        {
            //_context.ClassTimes.Join(_context.ScheduleBlockClassTimes.Where(a => 
            //a.ScheduleBlockId == scheduleBlockId).ToList(),
            //e => e.Id, 
            //o => o.ClassTimeId, 
            //(e, o) => new { e }
            //).ToList();
            return await _context.ScheduleBlockTeachers.Where(a => a.ScheduleBlockId == scheduleBlockId).ToListAsync();
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
