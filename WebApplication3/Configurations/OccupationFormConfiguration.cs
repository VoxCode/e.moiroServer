using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.moiroServer.Configurations
{
    public class OccupationFormConfiguration : IEntityTypeConfiguration<OccupationForm>
    {
        public void Configure(EntityTypeBuilder<OccupationForm> builder)
        {
            builder.HasData(
                new OccupationForm
                {
                    Id = 1,
                    FullName = "Лекция",
                    PluralName = "Лекции"
                },
                new OccupationForm
                {
                    Id = 2,
                    FullName = "Практическое занятие",
                    PluralName = "Практические занятия"
                },
                new OccupationForm
                {
                    Id = 3,
                    FullName = "Семинарское занятие",
                    PluralName = "Семинарские занятия"
                },
                new OccupationForm
                {
                    Id = 4,
                    FullName = "Круглый стол, тематическая дискуссия",
                    PluralName = "Круглые столы, тематические дискуссии"
                },
                new OccupationForm
                {
                    Id = 5,
                    FullName = "Лабораторное занятие",
                    PluralName = "Лабораторные занятия"
                },
                new OccupationForm
                {
                    Id = 6,
                    FullName = "Деловая игра",
                    PluralName = "Деловые игры"
                },
                new OccupationForm
                {
                    Id = 7,
                    FullName = "Тренинг",
                    PluralName = "Тренинги"
                },
                new OccupationForm
                {
                    Id = 8,
                    FullName = "Конференция",
                    PluralName = "Конференции"
                }
            );
        }
    }
}


