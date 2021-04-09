using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using System.Text;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.TrainingPrograms
                      join second in _context.Departments on first.DepartmentId equals second.Id
                      join third in _context.StudentCategories on first.StudentCategoryId equals third.Id
                      join fourth in _context.CertificationTypes on first.CertificationTypeId equals fourth.Id
                      join fifth in _context.FormOfEducations on first.FormOfEducationId equals fifth.Id
                      select new
                      {
                          first.Id,
                          first.Name,
                          first.NumberOfHours,
                          first.IsDistanceLearning,
                          first.IsControlWork,
                          first.IsTestWork,
                          first.ControlWork,
                          first.Introduction,
                          first.IntroductionData,
                          first.DepartmentId,
                          first.StudentCategoryId,
                          first.CertificationTypeId,
                          first.FormOfEducationId,
                          DepartmentName = second.Name,
                          StudentCategoryName = third.Name,
                          CertificationTypeName = fourth.Name,
                          FormOfEducationName = fifth.Name
                      };

            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgram>> Get(int id)
        {
            var value = await _context.TrainingPrograms.FindAsync(id);
            //value.Introduction =  Encoding.UTF8.GetString(value.IntroductionData);
            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgram value)
        {
            //value.IntroductionData = Encoding.UTF8.GetBytes(value.Introduction);
            //value.Introduction = "";
            if (ModelState.IsValid)
            {
                TrainingProgram trainingProgram = new TrainingProgram();
                trainingProgram.Id = value.Id;
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<TrainingProgram>> Post(TrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingPrograms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgram>> Delete(int id)
        {
            var value = await _context.TrainingPrograms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingPrograms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }      
    }
}
