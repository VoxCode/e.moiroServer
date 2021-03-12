using e.moiroServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    Name = "Кафедра дошкольного и начального образования"
                },
                new Department
                {
                    Name = "Кафедра психологии и управления"
                },
                new Department
                {
                    Name = "Кафедра частных методик общего среднего образования"
                }
            );
        }
    }
}
