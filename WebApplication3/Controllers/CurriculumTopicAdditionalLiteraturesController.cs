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
    public class CurriculumTopicAdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicAdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.CurriculumTopicAdditionalLiteratures
                      join second in _context.AdditionalLiteratures on first.AdditionalLiteratureId equals second.Id
                      select new
                      {
                          first.Id,
                          first.AdditionalLiteratureId,
                          first.CurriculumTopicId,
                          AdditionalLiteratureName = second.Content
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicAdditionalLiterature>>> Get(int id)
        {
            return await _context.CurriculumTopicAdditionalLiteratures.Where(a => a.CurriculumTopicId == id).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicAdditionalLiterature value)
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
        public async Task<ActionResult<CurriculumTopicAdditionalLiterature>> Post(CurriculumTopicAdditionalLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicAdditionalLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicAdditionalLiterature>> Delete(int id)
        {
            var value = await _context.CurriculumTopicAdditionalLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicAdditionalLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
