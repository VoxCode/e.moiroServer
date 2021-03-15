using e.moiroServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            string password = "235Cryptocertus";

            var hasher = new PasswordHasher<User>();

            builder.HasData(
                new User
                {
                    UserName = "root",
                    Email = "admin@bk.ru",
                    PasswordHash = hasher.HashPassword(null, password),
                }
            );

        }
    }
}
