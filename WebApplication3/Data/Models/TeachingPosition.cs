using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class TeachingPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
