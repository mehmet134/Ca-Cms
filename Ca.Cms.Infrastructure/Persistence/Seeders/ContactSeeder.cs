using Bogus;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Seeders
{
    public class ContactSeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Contacts.Any()) return;
            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<ContactEntity>()

                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Fullname))
                .RuleFor(u => u.Fullname, (f, u) => f.Name.FirstName() + f.Name.LastName)
                .RuleFor(u => u.Topic, (f, u) => f.Lorem.Word())
                .RuleFor(u => u.Phone, (f, u) => f.Random.Long(5111111111, 5999999999))
                .RuleFor(u => u.Text, (f, u) => f.Lorem.Paragraph());

            var list = faker.Generate(100);
            await context.Contacts.AddRangeAsync(list);
            await context.SaveChangesAsync();


        }
    }
}
