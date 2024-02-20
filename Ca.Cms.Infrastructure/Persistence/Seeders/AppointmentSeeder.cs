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
    public class AppointmentSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Appointments.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<AppointmentEntity>()

               .RuleFor(e => e.DateTime, c => new DateTime(c.Random.Int(2000, 2024), 1, 1))
               .RuleFor(u => u.CategoryId, (f, u) => f.PickRandom<DepartmentsEnum>())
               .RuleFor(o => o.DoctorId, f => f.Random.Int(1, 100))
               .RuleFor(o => o.PatientId, f => f.Random.Int(1, 100));

            ;

            var list = faker.Generate(100);
            await context.Appointments.AddRangeAsync(list);

            await context.SaveChangesAsync();
        }
    }
}
