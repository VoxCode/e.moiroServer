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
    public class ScheduleDatesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleDatesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleDate>>> Get()
        {
            return await _context.ScheduleDates.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleDate>> Get(int id)
        {
            var value = await _context.ScheduleDates.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("FromGroup/{groupId}")]
        public async Task<ActionResult<IEnumerable<ScheduleDate>>> GetFromScheduleDate(int groupId)
        {
            return await _context.ScheduleDates.Where(a => a.GroupId == groupId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleDate value)
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
        public async Task<ActionResult<ScheduleDate>> Post(ScheduleDate value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleDates.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleDate>> Delete(int id)
        {
            var value = await _context.ScheduleDates.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleDates.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
