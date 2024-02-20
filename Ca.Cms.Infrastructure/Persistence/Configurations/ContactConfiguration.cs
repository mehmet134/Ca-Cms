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
    public class ContactConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder
                .Property(x => x.Topic)
                .IsRequired()
                .HasMaxLength(30);
            builder
                .Property(x => x.Text) 
                .IsRequired()
                .HasMaxLength(500);
            builder
                .Property (x => x.Email)
                .IsRequired();
            builder
                .Property(x => x.Fullname)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(x => x.Phone)
                .IsRequired();

        }
    }
}
