
namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTrainingProgram
    {
        public int Id { get; set; }
        public bool IsVariable { get; set; }
        public int ClassHours { get; set; }
        public int SerialNumber { get; set; }
        public int CurriculumTopicId { get; set; }
        public int TrainingProgramId { get; set; }
        public int OccupationFormId { get; set; }
    }
}

