using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class OccupationForm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PluralName { get; set; }
        public ICollection<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public ICollection<OccupationFormMaxVariableTopicHour> OccupationFormMaxVariableTopicHours { get; set; }
    }
}