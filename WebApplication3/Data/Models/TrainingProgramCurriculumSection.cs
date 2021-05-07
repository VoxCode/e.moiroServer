using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgramCurriculumSection
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public string Name { get; set; }
        public int SectionNumber { get; set; }
        public ICollection<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public ICollection<OccupationForm> OccupationForms { get; set; }
        public ICollection<MaxVariableTopicTime> MaxVariableTopicTimes { get; set; }
    }
}
