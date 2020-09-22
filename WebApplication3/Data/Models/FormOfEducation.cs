using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class FormOfEducation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
