using e.moiroServer.Models;

namespace e.moiroServer.Data.Models.Identity
{
    public class RoleChangeModel: User
    {
        public string OldRole { get; set; }
        public string NewRole { get; set; }
    }
}
