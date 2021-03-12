using System.ComponentModel.DataAnnotations;

namespace e.moiroServer.Models.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
