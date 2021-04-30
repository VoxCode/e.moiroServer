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

        //[HttpGet("{curriculumTopicId}/{key}")]
        //public async Task<ActionResult<IEnumerable<Regulation>>> Get(int curriculumTopicId, int key)
        //{
        //    var result = await _context.Regulations.Where(a => a.CurriculumTopicRegulations
        //    .Any(r => r.CurriculumTopicId == curriculumTopicId)).ToListAsync();
        //    return result;
        //}

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

        //[HttpPost("{id}")]
        //public async Task<ActionResult<IEnumerable<Regulation>>> GetMainLiterature(int id, [FromBody] int[] curriculumTopicIdArray)
        //{
        //    IEnumerable<Regulation> result = new List<Regulation>();
        //    foreach (var i in curriculumTopicIdArray.AsParallel())
        //    {
        //        var res = await _context.Regulations.Where(a => a.CurriculumTopicRegulations
        //        .Any(r => r.CurriculumTopicId == i)).ToListAsync();
        //        result = result.Union(res);

        //    }

        //    return result.ToList();
        //}

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
