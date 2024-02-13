using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<DoctorEntity>
    {
        public void Configure(EntityTypeBuilder<DoctorEntity> builder)
        {
            builder.ToTable(nameof(DoctorEntity));

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
