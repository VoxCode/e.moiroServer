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
        public List<СurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiteratures { get; set; }

        public AdditionalLiterature()
        {
            СurriculumTopicAdditionalLiteratures = new List<СurriculumTopicAdditionalLiterature>();
        }
    }
}
