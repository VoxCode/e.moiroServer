﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicDepartment
    {
        public int Id { get; set; }
        public int CurriculumTopicId { get; set; }
        public int DepartmentId { get; set; }
    }
}
