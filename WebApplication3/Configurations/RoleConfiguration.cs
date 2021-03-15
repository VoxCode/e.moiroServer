using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Name = "Viewer",
                    NormalizedName = "VIEWER"
                },
                new IdentityRole
                {
                    Name = "Dean",
                    NormalizedName = "DEAN"
                },
                new IdentityRole
                {
                    Name = "Creator",
                    NormalizedName = "CREATOR"
                },
                new IdentityRole
                {
                    Name = "Editor",
                    NormalizedName = "EDITOR"
                }
            );
        }
    }
}
