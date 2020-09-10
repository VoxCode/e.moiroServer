using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicAdditionalLiterature
    {
        public int Id { get; set; }
        public int AdditionalLiteratureId { get; set; }
        public AdditionalLiterature AdditionalLiterature { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
