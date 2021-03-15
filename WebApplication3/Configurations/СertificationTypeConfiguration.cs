using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class CertificationTypeConfiguration : IEntityTypeConfiguration<CertificationType>
    {
        public void Configure(EntityTypeBuilder<CertificationType> builder)
        {
            builder.HasData(
                new CertificationType
                {
                    Id = 1,
                    Name = "Выпускная работа"
                },
                new CertificationType
                {
                    Id = 2,
                    Name = "Зачет"
                },
                new CertificationType
                {
                    Id = 3,
                    Name = "Экзамен"
                },
                new CertificationType
                {
                    Id = 4,
                    Name = "Собеседование в форме зачета"
                },
                new CertificationType
                {
                    Id = 5,
                    Name = "Собеседование в форме деловой игры"
                }
            );
        }
    }
}
