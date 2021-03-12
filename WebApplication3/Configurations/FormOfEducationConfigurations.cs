using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class FormOfEducationConfigurations : IEntityTypeConfiguration<FormOfEducation>
    {
        public void Configure(EntityTypeBuilder<FormOfEducation> builder)
        {
            builder.HasData(
                new FormOfEducation
                {
                    Name = "Очная"
                },
                new FormOfEducation
                {
                    Name = "Заочная"
                }
            );
        }
    }
}
