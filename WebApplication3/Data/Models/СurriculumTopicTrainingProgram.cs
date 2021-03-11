using System.Collections.Generic;

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
        public int? OccupationFormId { get; set; }
        public int TrainingProgrmaCurriculumSectionId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public OccupationForm OccupationForm { get; set; }
        public TrainingProgramCurriculumSection TrainingProgramCurriculumSection { get; set; }
        public List<ScheduleBlockCurriculumTopicTrainingProgram> ScheduleBlockCurriculumTopicTrainingPrograms { get; set; }
    }
}

