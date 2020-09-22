using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCathedral { get; set; }
        public int TeachingPositionId { get; set; }
        public List<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
    }
}
