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
    public class BlogCategorySeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.BlogCategories.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<BlogCategoryEntity>()


                .RuleFor(u => u.Title, (f, u) => f.PickRandom<BlogCategoriesEnum>().ToString());
            ;

            var list = faker.Generate(100);
            await context.BlogCategories.AddRangeAsync(list);

            await context.SaveChangesAsync();
        }
    }
}
