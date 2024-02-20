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
    public class CommentConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.ToTable(nameof(CommentEntity));

            builder
                .Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(300);
            
            builder.Property(t => t.BlogId).IsRequired();
            builder.Property(t => t.PatientId).IsRequired();
        }
    }
}
