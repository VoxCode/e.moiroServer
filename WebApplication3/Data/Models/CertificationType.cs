using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CertificationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FinalExamination> FinalExaminations { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
    }
}
