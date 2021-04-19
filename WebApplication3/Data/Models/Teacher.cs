using e.moiroServer.Models;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatronymicName { get; set; }
        public string Position { get; set; }
        public string AcademicRank { get; set; }
        public bool IsCathedral { get; set; }
        public List<User> Users { get; set; }
        public List<ScheduleBlockTeacher> ScheduleBlockTeachers { get; set; }
        public List<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
        public List<TeacherDepartment> TeacherDepartments { get; set; }
    }
}
