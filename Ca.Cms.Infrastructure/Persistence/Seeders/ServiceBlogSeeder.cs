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
    public class ServiceBlogSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.ServiceBlogs.Any()) return;
            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<ServiceBlogEntity>()
                .RuleFor(u => u.Title, (f, u) => f.Lorem.Word())
                .RuleFor(u => u.Description, (f, u) => f.Lorem.Paragraph());
            var list = faker.Generate(100);
            await context.ServiceBlogs.AddRangeAsync(list);
            await context.SaveChangesAsync();


        }
    }
}
