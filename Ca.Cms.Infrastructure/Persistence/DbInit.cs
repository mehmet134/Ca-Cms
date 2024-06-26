﻿using Ca.Cms.Infrastructure.Authentication;
using Ca.Cms.Infrastructure.Persistence.Common;
using Ca.Cms.Infrastructure.Persistence.Seeders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence
{
    public static class DbInitExtensions
    {
        public static async Task InitializeDb(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            await new DoctorSeeder().Seed(context);
            //var adminSeeder = new AdminSeeder(userManager, roleManager);
            //await adminSeeder.Seed(context);
            await new AdminSeeder().Seed(context);
            //await new AppointmentSeeder().Seed(context);
            await new PatientSeeder().Seed(context);
            await new BlogSeeder().Seed(context);
            await new BlogCategorySeeder().Seed(context);
            await new CommentSeeder().Seed(context);
            await new ContactSeeder().Seed(context);
            await new DepartmentBlogSeeder().Seed(context);
            await new ServiceBlogSeeder().Seed(context);
            await new DoctorCommentSeeder().Seed(context);
            await ApplyAllSeederFromAssembly(context);
        }
        private static async Task ApplyAllSeederFromAssembly(ApplicationDbContext context)
        {
            var seederType = typeof(ISeeder);
            var seeders = Assembly.GetExecutingAssembly().GetTypes()
                .Where(s => seederType.IsAssignableFrom(s) && s != seederType)
                .ToList();
            foreach (var type in seeders)
            {
                try
                {
                    var seeder = Activator.CreateInstance(type) as ISeeder;
                    await seeder?.Seed(context);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


    }
}
