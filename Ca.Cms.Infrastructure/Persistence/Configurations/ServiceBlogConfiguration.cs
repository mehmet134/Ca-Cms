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
    public class ServiceBlogConfiguration : IEntityTypeConfiguration<ServiceBlogEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceBlogEntity> builder)
        {
            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000);


        }
    }
}
