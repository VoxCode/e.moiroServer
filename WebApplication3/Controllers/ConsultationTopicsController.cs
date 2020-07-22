using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ConsultationTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultationTopic>>> Get()
        {
            return await _context.ConsultationTopics.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultationTopic>> Get(int id)
        {
            var value = await _context.ConsultationTopics.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(ConsultationTopic value)
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
        public async Task<ActionResult<ConsultationTopic>> Post(ConsultationTopic value)
        {
            if (ModelState.IsValid)
            {
                _context.ConsultationTopics.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsultationTopic>> Delete(int id)
        {
            var value = await _context.ConsultationTopics.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ConsultationTopics.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
