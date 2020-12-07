
namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTrainingProgram
    {
        public int Id { get; set; }
        public bool IsVariable { get; set; }
        public int ClassHours { get; set; }
        public int SerialNumber { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }
        public int CurriculumSectionId { get; set; }
        public CurriculumSection CurriculumSection { get; set; }
    }
}

