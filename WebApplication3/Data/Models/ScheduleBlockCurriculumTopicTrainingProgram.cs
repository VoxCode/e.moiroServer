
namespace e.moiroServer.Data.Models
{
    public class ScheduleBlockCurriculumTopicTrainingProgram
    {
        public int Id { get; set; }
        public int CurriculumTopicTrainingProgramId { get; set; }
        public int ScheduleBlockId { get; set; }
        public int SerialNumber { get; set; }

        public CurriculumTopicTrainingProgram CurriculumTopicTrainingProgram { get; set; }
        public ScheduleBlock ScheduleBlock { get; set; }
    }
}
