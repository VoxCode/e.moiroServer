using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public TrainingProgram()
        {
            CurriculumTopicTrainingPrograms = new List<CurriculumTopicTrainingProgram>();
        }
    }
}
