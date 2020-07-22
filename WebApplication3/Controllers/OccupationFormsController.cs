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
    public class OccupationFormsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OccupationFormsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OccupationForm>>> Get()
        {
            return await _context.OccupationForms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OccupationForm>> Get(int id)
        {
            var value = await _context.OccupationForms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(OccupationForm value)
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
        public async Task<ActionResult<OccupationForm>> Post(OccupationForm value)
        {
            if (ModelState.IsValid)
            {
                _context.OccupationForms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OccupationForm>> Delete(int id)
        {
            var value = await _context.OccupationForms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.OccupationForms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
