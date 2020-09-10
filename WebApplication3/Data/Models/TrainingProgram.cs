using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsDistanceLearning { get; set; }
        public bool IsIndependentWork { get; set; }
        public bool IsTestWork { get; set; }
        public string IndependentWork { get; set; }
        public string DepartmentId { get; set; }
        public string TeacherCategoryId { get; set; }
        public string CertificationTypeId { get; set; }
    }
}
