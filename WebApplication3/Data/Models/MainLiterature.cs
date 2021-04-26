using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class MainLiterature
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AuthorIndex { get; set; }
        public List<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public List<TrainingProgramMainLiterature> TrainingProgramMainLiteratures { get; set; }
    }
}
