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
    public class CertificationTypesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CertificationTypesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CertificationType>>> Get()
        {
            return await _context.CertificationTypes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CertificationType>> Get(int id)
        {
            var value = await _context.CertificationTypes.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CertificationType value)
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
        public async Task<ActionResult<CertificationType>> Post(CertificationType value)
        {
            if (ModelState.IsValid)
            {
                _context.CertificationTypes.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CertificationType>> Delete(int id)
        {
            var value = await _context.CertificationTypes.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CertificationTypes.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
