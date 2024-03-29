using Bogus;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Infrastructure.Authentication;
using Ca.Cms.Infrastructure.Persistence.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                Password = "1234384289432",
                Cv = "fdsjfıldjsfldjflıdjsfıjldsjfdsı",
                Address = "denizli"
            }
             ;
            //var adminUser = new ApplicationUser
            //{
            //    UserName = admin1.Email,
            //    Email = admin1.Email,
                


            //};
            //var result = await _userManager.CreateAsync(adminUser, "adminPassword123");
            //if (result.Succeeded)
            //{
            //    // Rolü kontrol edin ve yoksa oluşturun
            //    if (!await _roleManager.RoleExistsAsync("Admin"))
            //    {
            //        await _roleManager.CreateAsync(new IdentityRole("Admin"));
            //    }

            //    // Kullanıcıya 'Admin' rolünü atayın
            //    await _userManager.AddToRoleAsync(adminUser, "Admin");
            //}
            await context.Admins.AddAsync(admin1);
            await context.SaveChangesAsync();

        }
    }
}
