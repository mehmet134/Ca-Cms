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
    public class PatientSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Patients.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<PatientEntity>()

               .RuleFor(u => u.Password, "123qwe")
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(u => u.Name, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
                .RuleFor(e => e.Phone, c => c.Random.Long(5111111111, 5999999999))
                //Patients entitydeki phone burda string aklında olsun
                // Bir de address kısmı entityde hala duruyor.
            ;

            var list = faker.Generate(100);
            await context.Patients.AddRangeAsync(list);

            await context.SaveChangesAsync();
        }
    }
}
