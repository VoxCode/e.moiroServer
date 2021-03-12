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
                    Name = "Выпускная работа"
                },
                new CertificationType
                {
                    Name = "Зачет"
                },
                new CertificationType
                {
                    Name = "Экзамен"
                },
                new CertificationType
                {
                    Name = "Собеседование в форме зачета"
                },
                new CertificationType
                {
                    Name = "Собеседование в форме деловой игры"
                }
            );
        }
    }
}
