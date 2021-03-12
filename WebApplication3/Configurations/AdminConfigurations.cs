using e.moiroServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<UserManager<User>>
    {
        private readonly UserManager<User> userManager;
        public void Configure(EntityTypeBuilder<UserManager<User>> builder)
        {
            string role = "Viewer";
            string password = "235Cryptocertus";

            var user = new User
            {
                UserName = "root",
                Email = "admin@bk.ru",
            };

            userManager.CreateAsync(user, password);
            userManager.AddToRoleAsync(user, role);

            builder.HasData(userManager);
        }
    }
}
