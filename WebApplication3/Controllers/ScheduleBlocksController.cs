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
    public class ScheduleBlocksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlocksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlock>>> Get()
        {
            return await _context.ScheduleBlocks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlock>> Get(int id)
        {
            var value = await _context.ScheduleBlocks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("ScheduleElements")]
        public async Task<ActionResult<IEnumerable<object>>> GetScheduleElements()
        {
            var tmp = from dateBlock in _context.ScheduleDateScheduleBlocks
                      join date in _context.ScheduleDates on dateBlock.ScheduleDateId equals date.Id
                      join block in _context.ScheduleBlocks on dateBlock.ScheduleBlockId equals block.Id
                      join blockTopic in _context.ScheduleBlockCurriculumTopicTrainingPrograms on block.Id equals blockTopic.ScheduleBlockId
                      join topic in _context.CurriculumTopicTrainingPrograms on blockTopic.CurriculumTopicTrainingProgramId equals topic.Id
                      join blockTeacher in _context.ScheduleBlockTeachers on block.Id equals blockTeacher.ScheduleBlockId
                      join teacher in _context.Teachers on blockTeacher.TeacherId equals teacher.Id
                      join blockRoom in _context.ScheduleBlockClassRooms on block.Id equals blockRoom.ScheduleBlockId
                      join room in _context.ClassRooms on blockRoom.ClassRoomId equals room.Id
                      join blockTime in _context.ScheduleBlockClassTimes on block.Id equals blockTime.ScheduleBlockId
                      join time in _context.ClassTimes on blockTime.ClassTimeId equals time.Id
                      select new
                      {
                          dateBlock.ScheduleDateId,
                          dateBlock.ScheduleBlockId,
                          topic.TopicTitle,
                          blockTopic.CurriculumTopicTrainingProgramId,
                          teacherFullName = $"{teacher.LastName} {teacher.FirstName} {teacher.PatronymicName} ({teacher.Position})",
                          blockTeacher.TeacherId,
                          date.Date,
                          date.Group.GroupNumber,
                          date.GroupId,
                          block.SubgroupNumber,
                          blockTime.ClassTimeId,
                          time.ClassTimeStart,
                          time.ClassTimeEnd,
                          room.Name,
                          blockRoom.ClassRoomId,
                      };
            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        //[HttpDelete("ScheduleElement/{id}")]
        //public async Task<ActionResult<ScheduleBlock>> Delete(int id)
        //{
        //    var value = await _context.ScheduleBlocks.FindAsync(id);
        //    if (value == null)
        //    {
        //        return NotFound();
        //    }
        //    //_context.ScheduleDateScheduleBlocks.Remove(_context.ScheduleDateScheduleBlocks.Where(x => x.ScheduleBlockId == id));
        //    //_context.ScheduleDates.Remove();
        //    //_context.ScheduleBlocks.Remove();
        //    //_context.ScheduleBlockCurriculumTopicTrainingPrograms.Where(x => x.ScheduleBlockId == id).Remove();
        //    //_context.CurriculumTopicTrainingPrograms.Remove();
        //    //_context.ScheduleBlockTeachers.Remove();
        //    //_context.Teachers.Remove();
        //    //_context.ScheduleBlockClassRooms.Remove();
        //    //_context.ClassRooms.Remove();
        //    //_context.ScheduleBlockClassTimes.Remove();
        //    //_context.ClassTimes.Remove();

        //    //_context.ScheduleDates.Remove()
        //    _context.ScheduleBlocks.Remove(value);
        //    await _context.SaveChangesAsync();

        //    return value;
        //}

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlock value)
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
        public async Task<ActionResult<ScheduleBlock>> Post(ScheduleBlock value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlocks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlock>> Delete(int id)
        {
            var value = await _context.ScheduleBlocks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlocks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
