using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);


            builder.Property(e => e.Addres)
                .IsRequired()
                .HasMaxLength(150);


            builder.Property(e => e.Position)
                .IsRequired()
                .HasMaxLength (50);
        }
    }
}
