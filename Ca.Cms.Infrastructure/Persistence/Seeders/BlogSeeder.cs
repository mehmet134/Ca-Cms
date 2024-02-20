using Bogus;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Enums;
using Ca.Cms.Infrastructure.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Seeders
{
    public class BlogSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Blogs.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<BlogEntity>()

                .RuleFor(e => e.Title, c => trSet.JobTitle())
                .RuleFor(t => t.Description, c => c.Lorem.Sentence())
                .RuleFor(u => u.BlogCategoryId, (f, u) => f.PickRandom<BlogCategoriesEnum>())
            ;

            var list = faker.Generate(100);
            await context.Blogs.AddRangeAsync(list);

            await context.SaveChangesAsync();
        }
    }
}
