namespace e.moiroServer.Data.Models
{
    public class OccupationFormMaxVariableTopicHour
    {
        public int Id { get; set; }
        public int MaxVariableTopicHours { get; set; }
        public int OccupationFormId { get; set; }
        public int TrainingProgramCurriculumSectionId { get; set; }
        public TrainingProgramCurriculumSection TrainingProgramCurriculumSection { get; set; }
    }
}
