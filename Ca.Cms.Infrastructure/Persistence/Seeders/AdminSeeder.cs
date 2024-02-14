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
        public async Task Seed(ApplicationDbContext context)
        {
            if (context.Admins.Any()) return;
            
               var admin1 = new AdminEntity
               {
                   Id = 1,
                   Name = "Ali Rıza ",
                   Surname = "Canbulan",
                   Email = "aliriza@canbulan.com",
                   Phone = "05554442211",
                   Password = "1234",
                   Cv = "fdsjfıldjsfldjflıdjsfıjldsjfdsı"
               }
                ;
            await context.Admins.AddAsync(admin1);
            await context.SaveChangesAsync();
        }
    }
}
