using e.moiroServer.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace e.moiroServer.Models
{
    public class User : IdentityUser
    {
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
