using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class MainLiterature
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public MainLiterature()
        {
            CurriculumTopicMainLiteratures = new List<CurriculumTopicMainLiterature>();
        }
    }
}
