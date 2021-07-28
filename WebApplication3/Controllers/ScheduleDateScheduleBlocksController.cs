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
    public class ScheduleDateScheduleBlocksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleDateScheduleBlocksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleDateScheduleBlock>>> Get()
        {
            return await _context.ScheduleDateScheduleBlocks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleDateScheduleBlock>> Get(int id)
        {
            var value = await _context.ScheduleDateScheduleBlocks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromScheduleDate/{scheduleDateId}")]
        public async Task<ActionResult<IEnumerable<ScheduleDateScheduleBlock>>> GetFromScheduleDate(int scheduleDateId)
        {
            return await _context.ScheduleDateScheduleBlocks.Where(a => a.ScheduleDateId == scheduleDateId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleDateScheduleBlock value)
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
        public async Task<ActionResult<ScheduleDateScheduleBlock>> PutSerialNumbers([FromBody] List<ScheduleDateScheduleBlock> values)
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
        public async Task<ActionResult<ScheduleDateScheduleBlock>> Post(ScheduleDateScheduleBlock value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleDateScheduleBlocks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleDateScheduleBlock>> Delete(int id)
        {
            var value = await _context.ScheduleDateScheduleBlocks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleDateScheduleBlocks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
