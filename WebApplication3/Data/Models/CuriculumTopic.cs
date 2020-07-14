using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CuriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public int ClassHours { get; set; }
        public string Annotation { get; set; }
        public int CurriculumSectionId { get; set; }
        public int OccupationFormId { get; set; }
        public int DistanceLearningId { get; set; }

        public CurriculumSection CurriculumSection { get; set; }
        public OccupationForm OccupationForm { get; set; }
        public DistanceLearning DistanceLearning { get; set; }
    }
}
