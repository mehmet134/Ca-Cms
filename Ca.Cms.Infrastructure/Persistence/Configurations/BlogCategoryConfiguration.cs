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
    public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<BlogCategoryEntity> builder)
        {
            builder.ToTable(nameof(BlogCategoryEntity));

            builder
                .Property(x => x.Title)
                .IsRequired();
                
           

        }
    }
}
