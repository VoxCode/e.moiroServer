using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectionNumberId { get; set; }
        public List<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
    }
}
