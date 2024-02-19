using Ca.Cms.Domain.Common;
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

    public class AppointmentConfiguration : IEntityTypeConfiguration<AppointmentEntity>
    {
        public void Configure(EntityTypeBuilder<AppointmentEntity> builder)
        {
            builder.Property(t => t.CategoryId).IsRequired();
            builder.Property(t => t.PatientId).IsRequired();
            builder.Property(t => t.DoctorId).IsRequired();
            builder.Property(t => t.DateTime).IsRequired();
        }
    }
}
