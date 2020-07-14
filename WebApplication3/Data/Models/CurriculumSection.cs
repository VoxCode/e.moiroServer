using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectionNumberId { get; set; }

        public SectionNumber SectionNumber { get; set; }
    }
}
