namespace e.moiroServer.Data.Models
{
    public class OccupationFormClassHour
    {
        public int Id { get; set; }
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }
        public int CurriculumTopicTrainingProgramId { get; set; }
        public CurriculumTopicTrainingProgram CurriculumTopicTrainingProgram { get; set; }
        public int SerialNumber { get; set; }
        public int ClassHours { get; set; }
    }
}