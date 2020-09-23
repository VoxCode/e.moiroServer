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
    public class TrainingProgramRegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramRegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramRegulation>>> Get()
        {
            return await _context.TrainingProgramRegulations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramRegulation>> Get(int id)
        {
            var value = await _context.TrainingProgramRegulations.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramRegulation value)
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
        public async Task<ActionResult<TrainingProgramRegulation>> Post(TrainingProgramRegulation value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramRegulations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramRegulation>> Delete(int id)
        {
            var value = await _context.TrainingProgramRegulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramRegulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
