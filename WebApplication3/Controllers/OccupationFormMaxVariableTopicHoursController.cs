using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationFormMaxVariableTopicHoursController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OccupationFormMaxVariableTopicHoursController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OccupationFormMaxVariableTopicHour>>> Get()
        {
            return await _context.OccupationFormMaxVariableTopicHours.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OccupationFormMaxVariableTopicHour>> Get(int id)
        {
            var value = await _context.OccupationFormMaxVariableTopicHours.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(OccupationFormMaxVariableTopicHour value)
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
        public async Task<ActionResult<OccupationFormMaxVariableTopicHour>> Post(OccupationFormMaxVariableTopicHour value)
        {
            if (ModelState.IsValid)
            {
                _context.OccupationFormMaxVariableTopicHours.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OccupationFormMaxVariableTopicHour>> Delete(int id)
        {
            var value = await _context.OccupationFormMaxVariableTopicHours.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.OccupationFormMaxVariableTopicHours.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
