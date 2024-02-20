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
    public class BlogConfiguration : IEntityTypeConfiguration<BlogEntity>
    {
        public void Configure(EntityTypeBuilder<BlogEntity> builder)
        {
            builder.ToTable(nameof(BlogEntity));

            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(300);
            builder.Property(t => t.BlogCategoryId).IsRequired();

        }
    }
}
