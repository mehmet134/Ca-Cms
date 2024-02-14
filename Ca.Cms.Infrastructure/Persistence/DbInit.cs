﻿using Ca.Cms.Infrastructure.Persistence.Common;
using Microsoft.AspNetCore.Builder;
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
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
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
