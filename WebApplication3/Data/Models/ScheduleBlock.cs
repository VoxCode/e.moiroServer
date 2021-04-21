using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class ScheduleBlock
    {
        public int Id { get; set; }
        public int SubgroupNumber { get; set; }
        public int SerialNumber { get; set; }

        public List<ScheduleDateScheduleBlock> ScheduleDateSheduleBlocks { get; set; }
        public List<ScheduleBlockClassRoom> ScheduleBlockClassRooms { get; set; }
        public List<ScheduleBlockClassTime> ScheduleBlockClassTimes { get; set; }
        public List<ScheduleBlockTeacher> ScheduleBlockTeachers { get; set; }
        public List<ScheduleBlockCurriculumTopicTrainingProgram> ScheduleBlockCurriculumTopicTrainingPrograms { get; set; }
    }
}
