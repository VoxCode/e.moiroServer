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
    public class FormOfEducationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FormOfEducationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormOfEducation>>> Get()
        {
            return await _context.FormOfEducations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FormOfEducation>> Get(int id)
        {
            var value = await _context.FormOfEducations.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(FormOfEducation value)
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
        public async Task<ActionResult<FormOfEducation>> Post(FormOfEducation value)
        {
            if (ModelState.IsValid)
            {
                _context.FormOfEducations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FormOfEducation>> Delete(int id)
        {
            var value = await _context.FormOfEducations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.FormOfEducations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
