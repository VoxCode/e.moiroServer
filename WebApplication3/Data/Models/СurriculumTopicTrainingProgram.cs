using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTrainingProgram
    {
        public int Id { get; set; }
        public bool IsVariable { get; set; }
        public int ClassHours { get; set; }
        public int SerialNumber { get; set; }
        public string TopicTitle { get; set; }
        public string Annotation { get; set; }
        public int TrainingProgramCurriculumSectionId { get; set; }
        public TrainingProgramCurriculumSection TrainingProgramCurriculumSection { get; set; }
        public ICollection<ScheduleBlockCurriculumTopicTrainingProgram> ScheduleBlockCurriculumTopicTrainingPrograms { get; set; }
        public ICollection<OccupationForm> OccupationForms { get; set; }
        public ICollection<OccupationFormClassHour> OccupationFormClassHours { get; set; }
    }
}