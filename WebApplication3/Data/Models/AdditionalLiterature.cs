using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class AdditionalLiterature
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }
        public List<TrainingProgramAdditionalLiterature> TrainingProgramAdditionalLiteratures { get; set; }
    }
}
