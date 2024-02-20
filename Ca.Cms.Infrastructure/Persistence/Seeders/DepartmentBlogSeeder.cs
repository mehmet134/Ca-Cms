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
    public class DepartmentBlogSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.DepartmentBlogs.Any()) return;
            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<DepartmentBlogEntity>()
                .RuleFor(u => u.Name, (f, u) => f.Lorem.Word())
                .RuleFor(u => u.Description, (f, u) => f.Lorem.Paragraph());
            var list = faker.Generate(100);
            await context.DepartmentBlogs.AddRangeAsync(list);
            await context.SaveChangesAsync();

        }
    }
}
