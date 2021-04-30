using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorIndex { get; set; }
        public ICollection<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
    }
}
