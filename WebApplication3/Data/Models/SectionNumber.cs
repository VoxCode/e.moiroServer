using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class SectionNumber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CurriculumSection> CurriculumSections { get; set; }
    }
}
