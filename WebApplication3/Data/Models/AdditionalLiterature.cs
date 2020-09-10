using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class AdditionalLiterature
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }

        public AdditionalLiterature()
        {
            CurriculumTopicAdditionalLiteratures = new List<CurriculumTopicAdditionalLiterature>();
        }
    }
}
