using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ScheduleBlockClassRoom> ScheduleBlockClassRooms { get; set; }
    }
}
