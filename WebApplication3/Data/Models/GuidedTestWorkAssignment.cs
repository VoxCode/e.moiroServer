namespace e.moiroServer.Data.Models
{
    public class GuidedTestWorkAssignment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int SerialNumber { get; set; }
        public int CurriculumTopicTrainingProgramId { get; set; }
        public CurriculumTopicTrainingProgram CurriculumTopicTrainingProgram { get; set; }
    }
}
