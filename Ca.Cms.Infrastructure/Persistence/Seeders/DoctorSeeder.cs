using Bogus;
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
    public class DoctorSeeder : ISeeder
    {
        public async Task Seed(ApplicationDbContext context)
        {
            if (context.Doctors.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<DoctorEntity>()

                .RuleFor(u => u.CategoryId,1)
                .RuleFor(u => u.Password, "123qwe")
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(u => u.Name, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
            ;

            var list = faker.Generate(100);
            await context.Doctors.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}
