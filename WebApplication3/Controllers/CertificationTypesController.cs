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

        // GET: api/CertificationTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CertificationType>>> GetCertificationType()
        {
            return await _context.CertificationType.ToListAsync();
        }

        // GET: api/CertificationTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CertificationType>> GetCertificationType(int id)
        {
            var certificationType = await _context.CertificationType.FindAsync(id);

            if (certificationType == null)
            {
                return NotFound();
            }

            return certificationType;
        }

        // PUT: api/CertificationTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertificationType(int id, CertificationType certificationType)
        {
            if (id != certificationType.Id)
            {
                return BadRequest();
            }

            _context.Entry(certificationType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificationTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CertificationTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CertificationType>> PostCertificationType(CertificationType certificationType)
        {
            _context.CertificationType.Add(certificationType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertificationType", new { id = certificationType.Id }, certificationType);
        }

        // DELETE: api/CertificationTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CertificationType>> DeleteCertificationType(int id)
        {
            var certificationType = await _context.CertificationType.FindAsync(id);
            if (certificationType == null)
            {
                return NotFound();
            }

            _context.CertificationType.Remove(certificationType);
            await _context.SaveChangesAsync();

            return certificationType;
        }

        private bool CertificationTypeExists(int id)
        {
            return _context.CertificationType.Any(e => e.Id == id);
        }
    }
}
