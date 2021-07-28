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
    public class ScheduleBlockCurriculumTopicTrainingProgramsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlockCurriculumTopicTrainingProgramsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlockCurriculumTopicTrainingProgram>>> Get()
        {
            return await _context.ScheduleBlockCurriculumTopicTrainingPrograms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlockCurriculumTopicTrainingProgram>> Get(int id)
        {
            var value = await _context.ScheduleBlockCurriculumTopicTrainingPrograms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromScheduleBlock/{scheduleBlockId}")]
        public async Task<ActionResult<IEnumerable<ScheduleBlockCurriculumTopicTrainingProgram>>> GetFromScheduleBlock(int scheduleBlockId)
        {

            //var a = from topic in _context.CurriculumTopicTrainingPrograms
            //        join aux in _context.ScheduleBlockCurriculumTopicTrainingPrograms on topic.Id equals aux.CurriculumTopicTrainingProgramId
            //        where aux.ScheduleBlockId == scheduleBlockId
            //        select topic;

            //await _context.CurriculumTopicTrainingPrograms.
            //    Join(_context.ScheduleBlockCurriculumTopicTrainingPrograms,
            //        topic => topic.Id,
            //        schedule => schedule.CurriculumTopicTrainingProgramId,
            //        (topic, schedule) => new { topic, schedule }).
            //    Where(x => x.schedule.ScheduleBlockId == scheduleBlockId).
            //    Select(o => o.topic).ToListAsync();

            return await _context.ScheduleBlockCurriculumTopicTrainingPrograms.Where(a => a.ScheduleBlockId == scheduleBlockId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlockCurriculumTopicTrainingProgram value)
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
        public async Task<ActionResult<ScheduleBlockCurriculumTopicTrainingProgram>> PutSerialNumbers([FromBody] List<ScheduleBlockCurriculumTopicTrainingProgram> values)
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
        public async Task<ActionResult<ScheduleBlockCurriculumTopicTrainingProgram>> Post(ScheduleBlockCurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlockCurriculumTopicTrainingPrograms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlockCurriculumTopicTrainingProgram>> Delete(int id)
        {
            var value = await _context.ScheduleBlockCurriculumTopicTrainingPrograms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlockCurriculumTopicTrainingPrograms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}

