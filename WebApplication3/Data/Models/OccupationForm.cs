using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class OccupationForm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
    }
}
