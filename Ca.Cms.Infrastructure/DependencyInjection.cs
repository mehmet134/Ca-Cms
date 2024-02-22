using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Ca.Cms.Infrastructure.Persistence;
using Ca.Cms.Infrastructure.Persistence.Common;
using Ca.Cms.Infrastructure.Persistence.Interceptors;
using Ca.Cms.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
    {
       services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddSingleton(TimeProvider.System);

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IAdminRepository, AdminRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();


        //services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
        //services.AddScoped<IRepository<AdminEntity, int>, BaseRepository<AdminEntity, int>>();



        return services;
    }
}
