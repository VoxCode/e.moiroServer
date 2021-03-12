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
                    FullName = "Лекция",
                    PluralName = "Лекции"
                },
                new OccupationForm
                {
                    FullName = "Практическое занятие",
                    PluralName = "Практические занятия"
                },
                new OccupationForm
                {
                    FullName = "Семинарское занятие",
                    PluralName = "Семинарские занятия"
                },
                new OccupationForm
                {
                    FullName = "Круглый стол, тематическая дискуссия",
                    PluralName = "Круглые столы, тематические дискуссии"
                },
                new OccupationForm
                {
                    FullName = "Лабораторное занятие",
                    PluralName = "Лабораторные занятия"
                },
                new OccupationForm
                {
                    FullName = "Деловая игра",
                    PluralName = "Деловые игры"
                },
                new OccupationForm
                {
                    FullName = "Тренинг",
                    PluralName = "Тренинги"
                },
                new OccupationForm
                {
                    FullName = "Конференция",
                    PluralName = "Конференции"
                }
            );
        }
    }
}


