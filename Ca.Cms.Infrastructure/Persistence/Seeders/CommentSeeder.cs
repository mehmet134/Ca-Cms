using Bogus;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Infrastructure.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Seeders
{
    public class CommentSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Comments.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<CommentEntity>()

               
                .RuleFor(t => t.Text, c => c.Lorem.Sentence())
                .RuleFor(o => o.BlogId, f => f.Random.Int(1, 100))
                .RuleFor(o => o.PatientId, f => f.Random.Int(1, 100));
            ;

            var list = faker.Generate(100);
            await context.Comments.AddRangeAsync(list);

            await context.SaveChangesAsync();
        }
    }
}
