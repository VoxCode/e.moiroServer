using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string AcademicRank { get; set; }
        public bool IsCathedral { get; set; }
        List<ScheduleBlockTeachers> ScheduleBlockTeachers { get; set; }
    }
}
