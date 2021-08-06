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
    public class GuidedTestWorkAssignmentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public GuidedTestWorkAssignmentsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuidedTestWorkAssignment>>> Get()
        {
            return await _context.GuidedTestWorkAssignments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GuidedTestWorkAssignment>> Get(int id)
        {
            var value = await _context.GuidedTestWorkAssignments.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(GuidedTestWorkAssignment value)
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
        public async Task<ActionResult<GuidedTestWorkAssignment>> Post(GuidedTestWorkAssignment value)
        {
            if (ModelState.IsValid)
            {
                _context.GuidedTestWorkAssignments.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("FromCurriculumTopics")]
        public async Task<ActionResult<IEnumerable<GuidedTestWorkAssignment>>> GetFromCurriculumTopics([FromBody] int[] curriculumTopicIdArray)
        {
            IEnumerable<GuidedTestWorkAssignment> result = new List<GuidedTestWorkAssignment>();
            foreach (var curriculumTopicId in curriculumTopicIdArray.AsParallel())
            {
                var res = await _context.GuidedTestWorkAssignments
                    .Where(a => a.CurriculumTopicTrainingProgramId == curriculumTopicId).OrderBy(b => b.SerialNumber).ToListAsync();
                result = result.Union(res);
            }
            return result.ToList();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<GuidedTestWorkAssignment>> Delete(int id)
        {
            var value = await _context.GuidedTestWorkAssignments.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.GuidedTestWorkAssignments.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
