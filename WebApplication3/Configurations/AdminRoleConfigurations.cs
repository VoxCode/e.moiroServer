using e.moiroServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class AdminRoleConfigurations : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private readonly ApplicationContext context;
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var userId = context.Users.Find(1);
            var roleId = context.Roles.Find(1);

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId.Id,
                    UserId = userId.Id
                }
            );

        }
    }
}
