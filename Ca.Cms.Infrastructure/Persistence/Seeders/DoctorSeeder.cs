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
    public class DoctorSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            if (context.Doctors.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<DoctorEntity>()

                .RuleFor(u => u.Password, "123qwe")
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(u => u.Name, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
                .RuleFor(u => u.CategoryId,(f,u) => f.PickRandom<DepartmentsEnum>())
                //RuleFor(u => u.Phone , (f , u) => f.Phone.PhoneNumber())
                .RuleFor(e => e.Phone, c => c.Random.Long(5111111111, 5999999999).ToString())


            ;

            var list = faker.Generate(100);
            await context.Doctors.AddRangeAsync(list);
            //var admin1 = new DoctorEntity
            //{
            //    Name = "Ali Rıza ",
            //    Surname = "Canbulan",
            //    Email = "aliriza@canbulan.com",
            //    Password = "1234",



            //}
            //   ;
            //await context.Doctors.AddAsync(admin1);
            await context.SaveChangesAsync();
        }
    }
}
