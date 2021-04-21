using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.HasData(
                new Expert
                {
                    Id = 1,
                    Name = "Разработчик"
                },
                new Expert
                {
                    Id = 2,
                    Name = "Рецензент"
                }
            );
        }
    }
}
