using Bogus;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Infrastructure.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Seeders
{
    public class AdminSeeder : ISeeder
    {
        public async Task Seed(IApplicationDbContext context)
        {
            //if (context.Admins.Any()) return;

            //   var admin1 = new AdminEntity
            //   {
            //       Name = "Ali Rıza ",
            //       Surname = "Canbulan",
            //       Email = "aliriza@canbulan.com",
            //       Phone = "05554442211",
            //       Password = "1234",
            //       Cv = "fdsjfıldjsfldjflıdjsfıjldsjfdsı",
            //       Address = "denizli"
            //   }
            //    ;
            //await context.Admins.AddAsync(admin1);
            //await context.SaveChangesAsync();
            if (context.Doctors.Any()) return;

            var trSet = new Bogus.DataSets.Name(locale: "tr");

            var faker = new Faker<AdminEntity>()

                .RuleFor(u => u.Password, "123qwe")
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(u => u.Name, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
               
                //RuleFor(u => u.Phone , (f , u) => f.Phone.PhoneNumber())
                .RuleFor(e => e.Phone, c => c.Random.Long(5111111111, 5999999999).ToString())


            ;

            var list = faker.Generate(100);
            await context.Doctors.AddRangeAsync(list);
        }
    }
}
