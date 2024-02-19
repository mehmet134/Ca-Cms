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
            if (context.Admins.Any()) return;
            
               var admin1 = new AdminEntity
               {
                   Name = "Ali Rıza ",
                   Surname = "Canbulan",
                   Email = "aliriza@canbulan.com",
                   Phone = "05554442211",
                   Password = "1234",
                   Cv = "fdsjfıldjsfldjflıdjsfıjldsjfdsı",
                   Address = "denizli"
               }
                ;
            await context.Admins.AddAsync(admin1);
            await context.SaveChangesAsync();
        }
    }
}
