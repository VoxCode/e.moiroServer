﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int GroupNumber { get; set; }
        public DateTime CalendarYear { get; set; }
        public string TheTopicOfContinuingEducation { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public int NumberOfHours { get; set; }
        public int FormOfEducationId { get; set; }
        public int TeacherCategoryId { get; set; }
        public int DepartmensId { get; set; }

        public FormOfEducation FormOfEducation { get; set; }
        public TeacherCategory TeacherCategory { get; set; }
        public Departmens Departmens { get; set; }
    }
}