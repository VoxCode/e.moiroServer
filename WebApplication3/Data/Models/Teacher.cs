using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeachingPositionId { get; set; }
        public int CathedraId { get; set; }

        public TeachingPosition TeachingPosition { get; set; }
        public Cathedra Cathedra { get; set; }
    }
}
