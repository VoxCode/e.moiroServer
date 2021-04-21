using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    Id = 1,
                    Name = "Кафедра дошкольного и начального образования"
                },
                new Department
                {
                    Id = 2,
                    Name = "Кафедра психологии и управления"
                },
                new Department
                {
                    Id = 3,
                    Name = "Кафедра частных методик общего среднего образования"
                }
            );
        }
    }
}
