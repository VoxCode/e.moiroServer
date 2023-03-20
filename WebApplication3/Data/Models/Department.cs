﻿using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentHeadName { get; set; }
        public List<CurriculumTopic> CurriculumTopics { get; set; }
        public ICollection<TrainingProgram> TrainingPrograms { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<FinalExamination> FinalExaminations { get; set; }
    }
}
