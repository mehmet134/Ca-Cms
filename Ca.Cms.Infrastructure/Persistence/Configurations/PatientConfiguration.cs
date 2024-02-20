using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<PatientEntity>
    {
        public void Configure(EntityTypeBuilder<PatientEntity> builder)
        {
            builder.ToTable(nameof(PatientEntity));

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Email)
                .IsRequired();

        }
    }
}
