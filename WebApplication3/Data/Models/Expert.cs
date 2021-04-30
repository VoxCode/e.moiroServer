using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
    }
}
