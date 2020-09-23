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
    public class CurriculumTopicRegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicRegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicRegulation>>> Get()
        {
            return await _context.CurriculumTopicRegulations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicRegulation>> Get(int id)
        {
            var value = await _context.CurriculumTopicRegulations.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicRegulation value)
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
        public async Task<ActionResult<CurriculumTopicRegulation>> Post(CurriculumTopicRegulation value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicRegulations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicRegulation>> Delete(int id)
        {
            var value = await _context.CurriculumTopicRegulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicRegulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
