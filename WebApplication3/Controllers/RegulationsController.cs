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
    public class RegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public RegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Regulation>>> Get()
        {
            return await _context.Regulations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Regulation>> Get(int id)
        {
            var value = await _context.Regulations.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPost("CurriculumTopics")]
        public async Task<ActionResult<IEnumerable<Regulation>>> GetByCurriculumTopics([FromBody] int[] curriculumTopicIdArray)
        {
            IEnumerable<Regulation> regulationsResult = new List<Regulation>();
            foreach (int curriculumTopicId in curriculumTopicIdArray.AsParallel())
            {
                var res = await _context.Regulations.Where(a => a.CurriculumTopics.Any(b => b.Id == curriculumTopicId)).ToListAsync();
                regulationsResult = regulationsResult.Union(res);

            }
            return regulationsResult.ToList();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Regulation value)
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
        public async Task<ActionResult<Regulation>> Post(Regulation value)
        {
            if (ModelState.IsValid)
            {
                _context.Regulations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Regulation>> Delete(int id)
        {
            var value = await _context.Regulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Regulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
