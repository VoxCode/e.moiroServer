using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicAdditionalLiterature
    {
        public int Id { get; set; }
        public int AdditionalLiteratureId { get; set; }
        public int CuriculumTopicId { get; set; }

        public AdditionalLiterature AdditionalLiterature { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }
    }
}
