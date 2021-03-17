using e.moiroServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            string password = "235Cryptocertus";
            string role ="Administrator";

            var hasher = new PasswordHasher<IdentityUser>();

            builder.HasData(
                new IdentityUser
                {
                    UserName = "root",
                    Email = "admin@bk.ru",
                    PasswordHash = hasher.HashPassword(null, password),
                }
            );
        }
    }
}
